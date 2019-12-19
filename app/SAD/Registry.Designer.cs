namespace SAD
{
    partial class Registry
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registry));
            this.Confirm_btn = new ns1.BunifuThinButton2();
            this.SignUp = new ns1.BunifuThinButton2();
            this.confirmpasswordTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.passwordTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.addressTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.emailTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.nameTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new SAD.DatabaseDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new SAD.DatabaseDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new SAD.DatabaseDataSetTableAdapters.TableAdapterManager();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(449, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 17);
            label4.TabIndex = 151;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(84, 270);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 17);
            label3.TabIndex = 149;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(84, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 17);
            label2.TabIndex = 147;
            label2.Text = "Address";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(84, 108);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 17);
            emailLabel.TabIndex = 142;
            emailLabel.Text = "Email";
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.ActiveBorderThickness = 1;
            this.Confirm_btn.ActiveCornerRadius = 20;
            this.Confirm_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.Confirm_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Confirm_btn.ActiveLineColor = System.Drawing.Color.SlateGray;
            this.Confirm_btn.BackColor = System.Drawing.Color.Silver;
            this.Confirm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm_btn.BackgroundImage")));
            this.Confirm_btn.ButtonText = "Confirm";
            this.Confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.SlateGray;
            this.Confirm_btn.IdleBorderThickness = 1;
            this.Confirm_btn.IdleCornerRadius = 20;
            this.Confirm_btn.IdleFillColor = System.Drawing.Color.White;
            this.Confirm_btn.IdleForecolor = System.Drawing.Color.SlateGray;
            this.Confirm_btn.IdleLineColor = System.Drawing.Color.SlateGray;
            this.Confirm_btn.Location = new System.Drawing.Point(617, 355);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(133, 50);
            this.Confirm_btn.TabIndex = 154;
            this.Confirm_btn.TabStop = false;
            this.Confirm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
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
            this.SignUp.ButtonText = "Cancel";
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.SlateGray;
            this.SignUp.IdleBorderThickness = 1;
            this.SignUp.IdleCornerRadius = 20;
            this.SignUp.IdleFillColor = System.Drawing.Color.White;
            this.SignUp.IdleForecolor = System.Drawing.Color.SlateGray;
            this.SignUp.IdleLineColor = System.Drawing.Color.SlateGray;
            this.SignUp.Location = new System.Drawing.Point(452, 355);
            this.SignUp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(137, 50);
            this.SignUp.TabIndex = 153;
            this.SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // confirmpasswordTextBox
            // 
            this.confirmpasswordTextBox.BackColor = System.Drawing.Color.Silver;
            this.confirmpasswordTextBox.BorderColor = System.Drawing.Color.Black;
            this.confirmpasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordTextBox.Location = new System.Drawing.Point(452, 291);
            this.confirmpasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpasswordTextBox.MaxLength = 15;
            this.confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            this.confirmpasswordTextBox.Size = new System.Drawing.Size(298, 32);
            this.confirmpasswordTextBox.TabIndex = 152;
            this.confirmpasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Silver;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(87, 291);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.MaxLength = 15;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(297, 32);
            this.passwordTextBox.TabIndex = 150;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.Silver;
            this.addressTextBox.BorderColor = System.Drawing.Color.Black;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(87, 206);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.MaxLength = 150;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(663, 32);
            this.addressTextBox.TabIndex = 148;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Silver;
            this.emailTextBox.BorderColor = System.Drawing.Color.Black;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(87, 129);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 150;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(663, 32);
            this.emailTextBox.TabIndex = 146;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(84, 31);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel2.TabIndex = 145;
            this.bunifuCustomLabel2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Silver;
            this.nameTextBox.BorderColor = System.Drawing.Color.Black;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(87, 52);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 150;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(663, 32);
            this.nameTextBox.TabIndex = 144;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 143;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Confirm_btn_Click);
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
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.confirmpasswordTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(emailLabel);
            this.Name = "Registry";
            this.Size = new System.Drawing.Size(835, 437);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ns1.BunifuThinButton2 Confirm_btn;
        internal ns1.BunifuThinButton2 SignUp;
        internal WindowsFormsControlLibrary1.BunifuCustomTextbox confirmpasswordTextBox;
        internal WindowsFormsControlLibrary1.BunifuCustomTextbox passwordTextBox;
        internal WindowsFormsControlLibrary1.BunifuCustomTextbox addressTextBox;
        internal WindowsFormsControlLibrary1.BunifuCustomTextbox emailTextBox;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        internal WindowsFormsControlLibrary1.BunifuCustomTextbox nameTextBox;
        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
