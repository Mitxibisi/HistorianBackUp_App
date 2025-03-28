using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient; //Install-Package Microsoft.Data.SqlClient
using Microsoft.VisualBasic;

namespace HistorianBackUp_App
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        string path = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Evento del bot�n para conectar
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Recoger los datos ingresados por el usuario en los TextBox
            string server = txtServer.Text.Trim();
            string database = txtDatabase.Text.Trim();
            string user = txtUser.Text.Trim(); // Agregar TextBox para usuario
            string password = txtPassword.Text.Trim(); // Agregar TextBox para contrase�a

            // Crear la cadena de conexi�n
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Servidor y Base de Datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determinar el tipo de autenticaci�n
            string connectionString;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
            {
                connectionString = $"Server={server}; Database={database}; User Id={user}; Password={password}; TrustServerCertificate=True;";
            }
            else
            {
                connectionString = $"Server={server}; Database={database}; Trusted_Connection=True; TrustServerCertificate=True;";
            }

            // Intentar conectar con la base de datos
            connection = new SqlConnection(connectionString); // Mueve la creaci�n de la conexi�n fuera de using

            try
            {
                connection.Open();  // Establecer la conexi�n
                lblStatus.Text = "Conexi�n exitosa!";
                lblStatus.ForeColor = System.Drawing.Color.Green;  // Cambiar color de texto a verde
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las bases de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.ForeColor = System.Drawing.Color.Red;  // Cambiar color de texto a rojo
            }
        }

        // Evento para ejecutar la consulta
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text.Trim(); // Obtener el texto de la consulta del TextBox

            // Comprobar si la consulta est� vac�a
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, ingresa una consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandTimeout = 1000;

            // Ejecutar la consulta y mostrar los resultados
            using (command)
            {
                try
                {
                    // Crear un SqlDataReader para leer los resultados de la consulta
                    reader = command.ExecuteReader();

                    // Limpiar el ListBox antes de mostrar nuevos resultados
                    lstResults.Items.Clear();

                    while (reader.Read())
                    {
                        // Leer din�micamente todas las columnas
                        string result = string.Join(" | ",
                            Enumerable.Range(0, reader.FieldCount)
                                      .Select(i => reader.IsDBNull(i) ? "NULL" : reader.GetValue(i).ToString()));

                        lstResults.Items.Add(result);
                    }

                    reader.Close();  // Cerrar el SqlDataReader
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadQuery_Click(object sender, EventArgs e)
        {
            txtQuery.Text = "SELECT table_name\r\nFROM information_schema.tables\r\nWHERE table_type = 'BASE TABLE'";
        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                lblStatus.Text = "Conexion cerrada.";
                lblStatus.ForeColor = System.Drawing.Color.Red;  // Cambiar color de texto a rojo
            }
            else
            {
                MessageBox.Show("No hay una conexi�n activa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    label5.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Por favor, selecciona una carpeta para guardar el archivo CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"SELECT 
                    [TagName], 
                    1 AS FixedValue,
                    FORMAT([DateTime], 'yyyy/MM/dd|HH:mm:ss.fff') AS FormattedDateTime, -- Limitar a 3 decimales de milisegundos
	                0 AS FixedValue,
                    ROUND([Value], 3) AS Value, -- Redondear a 3 decimales en la columna Value
	                [OPCQuality]
                FROM 
                    [Runtime].[dbo].[v_History]
                WHERE 
                    TagName LIKE '{textBox2.Text}' 
                    AND wwRetrievalMode = '{comboBox1.Text.ToLower()}'
                    AND [DateTime] BETWEEN '{textBox1.Text}' AND '{textBox3.Text}'
                ORDER BY 
                    [DateTime] ASC;".Trim();

            txtQuery.Text = query;

            if (string.IsNullOrEmpty(query))// Comprobar si la consulta está vacía
            {
                MessageBox.Show("Por favor, ingresa una consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.CommandTimeout = 1000;

            // Ejecutar la consulta y mostrar los resultados
            using (command)
            {
                try
                {
                    // Limite de 4MB en bytes
                    const int maxFileSize = (4 * 1024 * 1024) - 194304; // 4MB

                    // Contador de archivos generados
                    int fileCounter = 1;

                    // Ruta del archivo inicial
                    string baseFileName = Path.Combine(path, "datos");
                    string fileName = $"{baseFileName}_{fileCounter}.csv";

                    // Crear el primer archivo CSV
                    StreamWriter writer = new StreamWriter(fileName, false, System.Text.Encoding.GetEncoding(1252));

                    // Escribir los encabezados solo una vez
                    writer.WriteLine("ASCII");
                    writer.WriteLine("|");
                    writer.WriteLine("Administrator|LOCAL|Server Local|10|0");

                    // Crear un SqlDataReader para leer los resultados de la consulta
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Leer dinámicamente todas las columnas
                        string result = string.Join("|",
                            Enumerable.Range(0, reader.FieldCount)
                                      .Select(i => reader.IsDBNull(i) ? "NULL" : reader.GetValue(i).ToString()));

                        // Verificar si el tamaño del archivo excede el límite
                        if (new FileInfo(fileName).Length + result.Length > maxFileSize)
                        {
                            // Cerrar el archivo actual
                            writer.Close();

                            // Incrementar el contador de archivos
                            fileCounter++;

                            // Generar un nuevo nombre de archivo
                            fileName = $"{baseFileName}_{fileCounter}.csv";

                            // Crear un nuevo archivo CSV
                            writer = new StreamWriter(fileName, false, System.Text.Encoding.GetEncoding(1252));

                            // Escribir los encabezados nuevamente en el nuevo archivo
                            writer.WriteLine("ASCII");
                            writer.WriteLine("|");
                            writer.WriteLine("Administrator|LOCAL|Server Local|10|0");
                        }

                        // Escribir la línea en el archivo CSV
                        writer.WriteLine(result);
                    }

                    // Cerrar el SqlDataReader
                    reader.Close();

                    // Cerrar el StreamWriter
                    writer.Close();

                    MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}