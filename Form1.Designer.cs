using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HistorianBackUp_App
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            tabQuery = new TabPage();
            btnLoadQuery = new Button();
            btnExecuteQuery = new Button();
            txtQuery = new TextBox();
            lstResults = new ListBox();
            tabConnection = new TabPage();
            groupBox2 = new GroupBox();
            txtUser = new TextBox();
            lblStatus = new Label();
            btnCloseConnection = new Button();
            lblPassword = new Label();
            btnConnect = new Button();
            txtPassword = new TextBox();
            txtServer = new TextBox();
            lblUser = new Label();
            txtDatabase = new TextBox();
            lblDatabase = new Label();
            lblServer = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnExport = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            lblPath = new Label();
            tabControl = new TabControl();
            tabQuery.SuspendLayout();
            tabConnection.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabQuery
            // 
            tabQuery.Controls.Add(btnLoadQuery);
            tabQuery.Controls.Add(btnExecuteQuery);
            tabQuery.Controls.Add(txtQuery);
            tabQuery.Controls.Add(lstResults);
            tabQuery.Location = new Point(4, 24);
            tabQuery.Name = "tabQuery";
            tabQuery.Padding = new Padding(3);
            tabQuery.Size = new Size(346, 417);
            tabQuery.TabIndex = 1;
            tabQuery.Text = "Consulta SQL";
            tabQuery.UseVisualStyleBackColor = true;
            // 
            // btnLoadQuery
            // 
            btnLoadQuery.Location = new Point(115, 6);
            btnLoadQuery.Name = "btnLoadQuery";
            btnLoadQuery.Size = new Size(70, 23);
            btnLoadQuery.TabIndex = 13;
            btnLoadQuery.Text = "Ver Tablas";
            btnLoadQuery.UseVisualStyleBackColor = true;
            btnLoadQuery.Click += btnLoadQuery_Click;
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.Location = new Point(9, 6);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new Size(100, 23);
            btnExecuteQuery.TabIndex = 10;
            btnExecuteQuery.Text = "Ejecutar Consulta";
            btnExecuteQuery.UseVisualStyleBackColor = true;
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(6, 35);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.ScrollBars = ScrollBars.Both;
            txtQuery.Size = new Size(334, 111);
            txtQuery.TabIndex = 11;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(6, 152);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(334, 259);
            lstResults.TabIndex = 12;
            // 
            // tabConnection
            // 
            tabConnection.Controls.Add(groupBox2);
            tabConnection.Controls.Add(groupBox1);
            tabConnection.Controls.Add(lblPath);
            tabConnection.Location = new Point(4, 24);
            tabConnection.Name = "tabConnection";
            tabConnection.Padding = new Padding(3);
            tabConnection.Size = new Size(346, 417);
            tabConnection.TabIndex = 0;
            tabConnection.Text = "Conexión";
            tabConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(btnCloseConnection);
            groupBox2.Controls.Add(lblPassword);
            groupBox2.Controls.Add(btnConnect);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtServer);
            groupBox2.Controls.Add(lblUser);
            groupBox2.Controls.Add(txtDatabase);
            groupBox2.Controls.Add(lblDatabase);
            groupBox2.Controls.Add(lblServer);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 228);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conexion";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(96, 146);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 23);
            txtUser.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 45);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(123, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Estado: Desconectado";
            // 
            // btnCloseConnection
            // 
            btnCloseConnection.Location = new Point(121, 16);
            btnCloseConnection.Name = "btnCloseConnection";
            btnCloseConnection.Size = new Size(100, 23);
            btnCloseConnection.TabIndex = 10;
            btnCloseConnection.Text = "Desconectar";
            btnCloseConnection.UseVisualStyleBackColor = true;
            btnCloseConnection.Click += btnCloseConnection_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(15, 189);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(15, 16);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(96, 66);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(216, 23);
            txtServer.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 149);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Usuario";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(96, 106);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(216, 23);
            txtDatabase.TabIndex = 3;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(15, 109);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(83, 15);
            lblDatabase.TabIndex = 4;
            lblDatabase.Text = "Base de Datos:";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(15, 69);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(74, 15);
            lblServer.TabIndex = 2;
            lblServer.Text = "Servidor (IP):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(6, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 172);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historian BackUp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 27);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "---";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(15, 146);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 27);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 101);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Tagname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 55);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Time Stamp";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "2024-11-18 16:30:00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "%";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Full", "Delta", "Cyclic", "Interpolated", "Bestfit", "Average", "Min", "Max", "Integral", "Slope", "Counter", "Valuestate", "Roundtrip" });
            comboBox1.Location = new Point(140, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Delta";
            // 
            // button1
            // 
            button1.Location = new Point(15, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Path";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "2024-09-18 16:24:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 99);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Retrival Mode";
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(72, 267);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(0, 15);
            lblPath.TabIndex = 6;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConnection);
            tabControl.Controls.Add(tabQuery);
            tabControl.Location = new Point(7, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(354, 445);
            tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(364, 451);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Conexión y Consultas SQL";
            tabQuery.ResumeLayout(false);
            tabQuery.PerformLayout();
            tabConnection.ResumeLayout(false);
            tabConnection.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabQuery;
        private Button btnLoadQuery;
        private Button btnExecuteQuery;
        private TextBox txtQuery;
        private ListBox lstResults;
        private TabPage tabConnection;
        private GroupBox groupBox1;
        private Button btnExport;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private Button btnCloseConnection;
        private Button btnConnect;
        private TextBox txtServer;
        private TextBox txtDatabase;
        private TextBox txtUser;
        private Label lblServer;
        private Label lblDatabase;
        private Label lblPath;
        private Label lblUser;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblStatus;
        private TabControl tabControl;
        private GroupBox groupBox2;
        private Label label5;
    }
}
