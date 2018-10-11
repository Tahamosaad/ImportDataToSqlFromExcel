namespace UpdateSEFData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labStatus = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDB = new System.Windows.Forms.GroupBox();
            this.txt_DBname = new System.Windows.Forms.TextBox();
            this.txt_Servername = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtDBUsername = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblDBPassword = new System.Windows.Forms.Label();
            this.lblDBUserName = new System.Windows.Forms.Label();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.grpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(8, 252);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(38, 13);
            this.labStatus.TabIndex = 0;
            this.labStatus.Text = "Status";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(99, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpDB
            // 
            this.grpDB.Controls.Add(this.txt_DBname);
            this.grpDB.Controls.Add(this.txt_Servername);
            this.grpDB.Controls.Add(this.lblServerName);
            this.grpDB.Controls.Add(this.txtDBUsername);
            this.grpDB.Controls.Add(this.lblDatabase);
            this.grpDB.Controls.Add(this.lblDBPassword);
            this.grpDB.Controls.Add(this.lblDBUserName);
            this.grpDB.Controls.Add(this.txtDBPassword);
            this.grpDB.ForeColor = System.Drawing.Color.Black;
            this.grpDB.Location = new System.Drawing.Point(11, 19);
            this.grpDB.Name = "grpDB";
            this.grpDB.Size = new System.Drawing.Size(380, 194);
            this.grpDB.TabIndex = 8;
            this.grpDB.TabStop = false;
            this.grpDB.Text = "Database Information";
            // 
            // txt_DBname
            // 
            this.txt_DBname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DBname.Location = new System.Drawing.Point(120, 120);
            this.txt_DBname.Name = "txt_DBname";
            this.txt_DBname.Size = new System.Drawing.Size(181, 22);
            this.txt_DBname.TabIndex = 2;
            // 
            // txt_Servername
            // 
            this.txt_Servername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Servername.Location = new System.Drawing.Point(120, 42);
            this.txt_Servername.Name = "txt_Servername";
            this.txt_Servername.Size = new System.Drawing.Size(181, 22);
            this.txt_Servername.TabIndex = 0;
            // 
            // lblServerName
            // 
            this.lblServerName.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.ForeColor = System.Drawing.Color.Black;
            this.lblServerName.Location = new System.Drawing.Point(29, 42);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(85, 19);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name";
            // 
            // txtDBUsername
            // 
            this.txtDBUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBUsername.Location = new System.Drawing.Point(120, 68);
            this.txtDBUsername.Name = "txtDBUsername";
            this.txtDBUsername.Size = new System.Drawing.Size(181, 22);
            this.txtDBUsername.TabIndex = 111;
            this.txtDBUsername.TabStop = false;
            this.txtDBUsername.Visible = false;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblDatabase.Location = new System.Drawing.Point(29, 120);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(85, 19);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Database";
            // 
            // lblDBPassword
            // 
            this.lblDBPassword.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBPassword.ForeColor = System.Drawing.Color.Black;
            this.lblDBPassword.Location = new System.Drawing.Point(29, 94);
            this.lblDBPassword.Name = "lblDBPassword";
            this.lblDBPassword.Size = new System.Drawing.Size(85, 19);
            this.lblDBPassword.TabIndex = 3;
            this.lblDBPassword.Text = "Password";
            // 
            // lblDBUserName
            // 
            this.lblDBUserName.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBUserName.ForeColor = System.Drawing.Color.Black;
            this.lblDBUserName.Location = new System.Drawing.Point(29, 68);
            this.lblDBUserName.Name = "lblDBUserName";
            this.lblDBUserName.Size = new System.Drawing.Size(85, 19);
            this.lblDBUserName.TabIndex = 0;
            this.lblDBUserName.Text = "Username";
            this.lblDBUserName.Visible = false;
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPassword.Location = new System.Drawing.Point(120, 94);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.PasswordChar = '*';
            this.txtDBPassword.Size = new System.Drawing.Size(181, 22);
            this.txtDBPassword.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpDB);
            this.Controls.Add(this.labStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update SEF Data";
            this.grpDB.ResumeLayout(false);
            this.grpDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStatus;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.GroupBox grpDB;
        internal System.Windows.Forms.TextBox txt_DBname;
        internal System.Windows.Forms.TextBox txt_Servername;
        internal System.Windows.Forms.Label lblServerName;
        internal System.Windows.Forms.TextBox txtDBUsername;
        internal System.Windows.Forms.Label lblDatabase;
        internal System.Windows.Forms.Label lblDBPassword;
        internal System.Windows.Forms.Label lblDBUserName;
        internal System.Windows.Forms.TextBox txtDBPassword;
    }
}

