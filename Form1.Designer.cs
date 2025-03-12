using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HistorianBackUp_App
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.TabControl tabControl;
            private System.Windows.Forms.TabPage tabConnection;
            private System.Windows.Forms.TabPage tabQuery;
            private System.Windows.Forms.Button btnConnect;
            private System.Windows.Forms.Button btnExecuteQuery;
            private System.Windows.Forms.TextBox txtQuery;
            private System.Windows.Forms.ListBox lstResults;
            private System.Windows.Forms.Label lblServer;
            private System.Windows.Forms.TextBox txtServer;
            private System.Windows.Forms.Label lblDatabase;
            private System.Windows.Forms.TextBox txtDatabase;
            private System.Windows.Forms.Label lblStatus;
            private System.Windows.Forms.TextBox txtUser;
            private System.Windows.Forms.Label lblUser;
            private System.Windows.Forms.TextBox txtPassword;
            private System.Windows.Forms.Label lblPassword;
            private System.Windows.Forms.Button btnLoadQuery;
            private System.Windows.Forms.Button btnCloseConnection;
            private System.Windows.Forms.Button Plantilla;

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
            tabControl = new TabControl();
            tabConnection = new TabPage();
            btnCloseConnection = new Button();
            btnConnect = new Button();
            txtServer = new TextBox();
            lblServer = new Label();
            txtDatabase = new TextBox();
            lblDatabase = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblStatus = new Label();
            tabQuery = new TabPage();
            Plantilla = new Button();
            btnLoadQuery = new Button();
            btnExecuteQuery = new Button();
            txtQuery = new TextBox();
            lstResults = new ListBox();
            tabPage1 = new TabPage();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl.SuspendLayout();
            tabConnection.SuspendLayout();
            tabQuery.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConnection);
            tabControl.Controls.Add(tabQuery);
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(350, 420);
            tabControl.TabIndex = 0;
            // 
            // tabConnection
            // 
            tabConnection.Controls.Add(btnCloseConnection);
            tabConnection.Controls.Add(btnConnect);
            tabConnection.Controls.Add(txtServer);
            tabConnection.Controls.Add(lblServer);
            tabConnection.Controls.Add(txtDatabase);
            tabConnection.Controls.Add(lblDatabase);
            tabConnection.Controls.Add(txtUser);
            tabConnection.Controls.Add(lblUser);
            tabConnection.Controls.Add(txtPassword);
            tabConnection.Controls.Add(lblPassword);
            tabConnection.Controls.Add(lblStatus);
            tabConnection.Location = new Point(4, 24);
            tabConnection.Name = "tabConnection";
            tabConnection.Padding = new Padding(3);
            tabConnection.Size = new Size(342, 392);
            tabConnection.TabIndex = 0;
            tabConnection.Text = "Conexión";
            tabConnection.UseVisualStyleBackColor = true;
            // 
            // btnCloseConnection
            // 
            btnCloseConnection.Location = new Point(118, 12);
            btnCloseConnection.Name = "btnCloseConnection";
            btnCloseConnection.Size = new Size(100, 23);
            btnCloseConnection.TabIndex = 10;
            btnCloseConnection.Text = "Desconectar";
            btnCloseConnection.UseVisualStyleBackColor = true;
            btnCloseConnection.Click += btnCloseConnection_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(93, 60);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(216, 23);
            txtServer.TabIndex = 1;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(12, 63);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(74, 15);
            lblServer.TabIndex = 2;
            lblServer.Text = "Servidor (IP):";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(93, 100);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(216, 23);
            txtDatabase.TabIndex = 3;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(12, 103);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(83, 15);
            lblDatabase.TabIndex = 4;
            lblDatabase.Text = "Base de Datos:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(93, 140);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 23);
            txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 143);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 220);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(123, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Estado: Desconectado";
            // 
            // tabQuery
            // 
            tabQuery.Controls.Add(Plantilla);
            tabQuery.Controls.Add(btnLoadQuery);
            tabQuery.Controls.Add(btnExecuteQuery);
            tabQuery.Controls.Add(txtQuery);
            tabQuery.Controls.Add(lstResults);
            tabQuery.Location = new Point(4, 24);
            tabQuery.Name = "tabQuery";
            tabQuery.Padding = new Padding(3);
            tabQuery.Size = new Size(342, 392);
            tabQuery.TabIndex = 1;
            tabQuery.Text = "Consulta SQL";
            tabQuery.UseVisualStyleBackColor = true;
            // 
            // Plantilla
            // 
            Plantilla.Location = new Point(191, 6);
            Plantilla.Name = "Plantilla";
            Plantilla.Size = new Size(75, 23);
            Plantilla.TabIndex = 14;
            Plantilla.Text = "Plantillas";
            Plantilla.UseVisualStyleBackColor = true;
            Plantilla.Click += btnTemplates_Click;
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
            txtQuery.Location = new Point(9, 35);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.ScrollBars = ScrollBars.Both;
            txtQuery.Size = new Size(324, 77);
            txtQuery.TabIndex = 11;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(9, 118);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(324, 259);
            lstResults.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(342, 392);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "2024-11-18 16:30:00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "%";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "2024-09-18 16:24:00";
            // 
            // Form1
            // 
            ClientSize = new Size(374, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Conexión y Consultas SQL";
            tabControl.ResumeLayout(false);
            tabConnection.ResumeLayout(false);
            tabConnection.PerformLayout();
            tabQuery.ResumeLayout(false);
            tabQuery.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }
        private TabPage tabPage1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
