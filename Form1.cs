using System.Data;
using Microsoft.Data.SqlClient; //Install-Package Microsoft.Data.SqlClient

namespace HistorianBackUp_App
{
        public partial class Form1 : Form
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;

            public Form1()
            {
                InitializeComponent();
            }
            // Evento del botón para conectar
            private void btnConnect_Click(object sender, EventArgs e)
            {
                // Recoger los datos ingresados por el usuario en los TextBox
                string server = txtServer.Text.Trim();
                string database = txtDatabase.Text.Trim();
                string user = txtUser.Text.Trim(); // Agregar TextBox para usuario
                string password = txtPassword.Text.Trim(); // Agregar TextBox para contraseña

                // Crear la cadena de conexión
                if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
                {
                    MessageBox.Show("Servidor y Base de Datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determinar el tipo de autenticación
                string connectionString;
                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
                {
                    connectionString = $"Server={server}; Database={database}; User Id={user}; Password={password}; TrustServerCertificate=True;";
                }
                else
                {
                    connectionString = $"Server={server}; Database={database}; TrustServerCertificate=True;";
                }

                // Intentar conectar con la base de datos
                connection = new SqlConnection(connectionString); // Mueve la creación de la conexión fuera de using

                try
                {
                    connection.Open();  // Establecer la conexión
                    lblStatus.Text = "Conexión exitosa!";
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
                
                // Comprobar si la consulta está vacía
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
                        // Leer dinámicamente todas las columnas
                        string result = string.Join("|",
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
                }
                else
                {
                    MessageBox.Show("No hay una conexión activa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void btnTemplates_Click(object sender, EventArgs e)
            {
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
                    AND wwRetrievalMode = 'full' 
                    AND [DateTime] BETWEEN '{textBox1.Text}' AND '{textBox3.Text}'
                ORDER BY 
                    [DateTime] ASC;";

                txtQuery.Text = query;
            }
        }
}
