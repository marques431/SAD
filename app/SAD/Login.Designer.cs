namespace SAD
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.Login_btn = new ns1.BunifuThinButton2();
            this.SignUp = new ns1.BunifuThinButton2();
            this.Password = new ns1.BunifuMaterialTextbox();
            this.Username = new ns1.BunifuMaterialTextbox();
            this.BunifuImageButton1 = new ns1.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new SAD.DatabaseDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new SAD.DatabaseDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new SAD.DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Silver;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(472, 253);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 23);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 140;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BunifuImageButton2_MouseDown);
            this.bunifuImageButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BunifuImageButton2_MouseUp);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(506, 253);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(162, 23);
            this.bunifuCustomLabel2.TabIndex = 139;
            this.bunifuCustomLabel2.Text = "Show Password";
            // 
            // Login_btn
            // 
            this.Login_btn.ActiveBorderThickness = 1;
            this.Login_btn.ActiveCornerRadius = 20;
            this.Login_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.Login_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Login_btn.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.Login_btn.BackColor = System.Drawing.Color.Silver;
            this.Login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn.BackgroundImage")));
            this.Login_btn.ButtonText = "Login";
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.SlateGray;
            this.Login_btn.IdleBorderThickness = 1;
            this.Login_btn.IdleCornerRadius = 20;
            this.Login_btn.IdleFillColor = System.Drawing.Color.White;
            this.Login_btn.IdleForecolor = System.Drawing.Color.SlateGray;
            this.Login_btn.IdleLineColor = System.Drawing.Color.SlateGray;
            this.Login_btn.Location = new System.Drawing.Point(664, 319);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(151, 50);
            this.Login_btn.TabIndex = 138;
            this.Login_btn.TabStop = false;
            this.Login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // SignUp
            // 
            this.SignUp.ActiveBorderThickness = 1;
            this.SignUp.ActiveCornerRadius = 20;
            this.SignUp.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.SignUp.ActiveForecolor = System.Drawing.Color.White;
            this.SignUp.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.SignUp.BackColor = System.Drawing.Color.Silver;
            this.SignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUp.BackgroundImage")));
            this.SignUp.ButtonText = "SignUp";
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.SlateGray;
            this.SignUp.IdleBorderThickness = 1;
            this.SignUp.IdleCornerRadius = 20;
            this.SignUp.IdleFillColor = System.Drawing.Color.White;
            this.SignUp.IdleForecolor = System.Drawing.Color.SlateGray;
            this.SignUp.IdleLineColor = System.Drawing.Color.SlateGray;
            this.SignUp.Location = new System.Drawing.Point(474, 319);
            this.SignUp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(137, 50);
            this.SignUp.TabIndex = 137;
            this.SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.Password.HintText = "Password";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.Black;
            this.Password.LineIdleColor = System.Drawing.Color.SlateGray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.Password.LineThickness = 4;
            this.Password.Location = new System.Drawing.Point(474, 163);
            this.Password.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(341, 46);
            this.Password.TabIndex = 136;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.Username.HintText = "Username";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.Black;
            this.Username.LineIdleColor = System.Drawing.Color.SlateGray;
            this.Username.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.Username.LineThickness = 1;
            this.Username.Location = new System.Drawing.Point(474, 73);
            this.Username.Margin = new System.Windows.Forms.Padding(0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(341, 46);
            this.Username.TabIndex = 135;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuImageButton1.Enabled = false;
            this.BunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton1.Image")));
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(19, 50);
            this.BunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(411, 337);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton1.TabIndex = 134;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 133;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.databaseDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MicroinversorTableAdapter = null;
            this.tableAdapterManager.PanelTableAdapter = null;
            this.tableAdapterManager.SimulationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SAD.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.BunifuImageButton1);
            this.Controls.Add(this.button1);
            this.Name = "Login1";
            this.Size = new System.Drawing.Size(835, 437);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ns1.BunifuImageButton bunifuImageButton2;
        internal ns1.BunifuCustomLabel bunifuCustomLabel2;
        internal ns1.BunifuThinButton2 Login_btn;
        internal ns1.BunifuThinButton2 SignUp;
        internal ns1.BunifuMaterialTextbox Password;
        internal ns1.BunifuMaterialTextbox Username;
        internal ns1.BunifuImageButton BunifuImageButton1;
        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
