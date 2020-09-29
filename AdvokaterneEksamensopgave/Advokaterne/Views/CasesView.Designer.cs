namespace Advokaterne.Views
{
    partial class CasesView
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
            this.ComboCases = new System.Windows.Forms.ComboBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnCase = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSpecial = new System.Windows.Forms.ComboBox();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.comboEmployee = new System.Windows.Forms.ComboBox();
            this.lblCustomID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.DescriptionTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboCases
            // 
            this.ComboCases.FormattingEnabled = true;
            this.ComboCases.Items.AddRange(new object[] {
            "Ny Case"});
            this.ComboCases.Location = new System.Drawing.Point(432, 35);
            this.ComboCases.Name = "ComboCases";
            this.ComboCases.Size = new System.Drawing.Size(177, 21);
            this.ComboCases.TabIndex = 1;
            this.ComboCases.Text = "Vælg en Case";
            this.ComboCases.SelectedIndexChanged += new System.EventHandler(this.ComboCases_SelectedIndexChanged);
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Items.AddRange(new object[] {
            "Opret kunde"});
            this.comboClient.Location = new System.Drawing.Point(21, 30);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(141, 21);
            this.comboClient.TabIndex = 3;
            this.comboClient.Text = "Vælg en kunde";
            this.comboClient.SelectedIndexChanged += new System.EventHandler(this.comboClient_SelectedIndexChanged);
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(21, 75);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(141, 20);
            this.txtfName.TabIndex = 14;
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(21, 112);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(141, 20);
            this.txtlName.TabIndex = 15;
            // 
            // txtCPR
            // 
            this.txtCPR.Location = new System.Drawing.Point(21, 152);
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(141, 20);
            this.txtCPR.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(21, 241);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(141, 20);
            this.txtTlf.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(21, 279);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fornavn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Efternavn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "CPR med \"-\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tlf";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phone";
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.Location = new System.Drawing.Point(21, 305);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(141, 23);
            this.BtnCustomer.TabIndex = 26;
            this.BtnCustomer.Text = "Opret kunde";
            this.BtnCustomer.UseVisualStyleBackColor = true;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnCase
            // 
            this.BtnCase.Location = new System.Drawing.Point(432, 279);
            this.BtnCase.Name = "BtnCase";
            this.BtnCase.Size = new System.Drawing.Size(177, 23);
            this.BtnCase.TabIndex = 28;
            this.BtnCase.Text = "Opret case";
            this.BtnCase.UseVisualStyleBackColor = true;
            this.BtnCase.Click += new System.EventHandler(this.BtnCase_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(432, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(429, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Subject";
            // 
            // comboSpecial
            // 
            this.comboSpecial.FormattingEnabled = true;
            this.comboSpecial.Location = new System.Drawing.Point(432, 217);
            this.comboSpecial.Name = "comboSpecial";
            this.comboSpecial.Size = new System.Drawing.Size(177, 21);
            this.comboSpecial.TabIndex = 34;
            this.comboSpecial.Text = "Område";
            this.comboSpecial.SelectedIndexChanged += new System.EventHandler(this.comboSpecial_SelectedIndexChanged);
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Location = new System.Drawing.Point(429, 14);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(0, 13);
            this.lblCaseID.TabIndex = 35;
            // 
            // comboEmployee
            // 
            this.comboEmployee.FormattingEnabled = true;
            this.comboEmployee.Location = new System.Drawing.Point(432, 256);
            this.comboEmployee.Name = "comboEmployee";
            this.comboEmployee.Size = new System.Drawing.Size(177, 21);
            this.comboEmployee.TabIndex = 36;
            // 
            // lblCustomID
            // 
            this.lblCustomID.AutoSize = true;
            this.lblCustomID.Location = new System.Drawing.Point(23, 14);
            this.lblCustomID.Name = "lblCustomID";
            this.lblCustomID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomID.TabIndex = 38;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(187, 38);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerID.TabIndex = 37;
            // 
            // DescriptionTextBox1
            // 
            this.DescriptionTextBox1.Location = new System.Drawing.Point(376, 104);
            this.DescriptionTextBox1.Name = "DescriptionTextBox1";
            this.DescriptionTextBox1.Size = new System.Drawing.Size(264, 107);
            this.DescriptionTextBox1.TabIndex = 39;
            this.DescriptionTextBox1.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Slet valgte case";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DescriptionTextBox1);
            this.Controls.Add(this.lblCustomID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.comboEmployee);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.comboSpecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnCase);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPR);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.ComboCases);
            this.Name = "CasesView";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.CasesView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCases;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnCase;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSpecial;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.ComboBox comboEmployee;
        private System.Windows.Forms.Label lblCustomID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.RichTextBox DescriptionTextBox1;
        private System.Windows.Forms.Button btnDelete;
    }
}
