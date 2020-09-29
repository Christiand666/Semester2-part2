namespace Advokaterne.Views
{
    partial class ServiceView
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
            this.BtnAction = new System.Windows.Forms.Button();
            this.comboCase = new System.Windows.Forms.ComboBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioIsHourlyPay = new System.Windows.Forms.RadioButton();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAction
            // 
            this.BtnAction.Location = new System.Drawing.Point(176, 374);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(314, 62);
            this.BtnAction.TabIndex = 40;
            this.BtnAction.Text = "Vælg en service";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // comboCase
            // 
            this.comboCase.FormattingEnabled = true;
            this.comboCase.Location = new System.Drawing.Point(338, 50);
            this.comboCase.Name = "comboCase";
            this.comboCase.Size = new System.Drawing.Size(141, 21);
            this.comboCase.TabIndex = 27;
            this.comboCase.Text = "Vælg en case";
            this.comboCase.SelectedIndexChanged += new System.EventHandler(this.comboClient_SelectedIndexChanged);
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(183, 34);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(0, 13);
            this.lblServiceID.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Name";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(259, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fast løn";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(203, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 20);
            this.txtPrice.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Pris";
            // 
            // radioIsHourlyPay
            // 
            this.radioIsHourlyPay.AutoSize = true;
            this.radioIsHourlyPay.Location = new System.Drawing.Point(176, 122);
            this.radioIsHourlyPay.Name = "radioIsHourlyPay";
            this.radioIsHourlyPay.Size = new System.Drawing.Size(77, 17);
            this.radioIsHourlyPay.TabIndex = 44;
            this.radioIsHourlyPay.TabStop = true;
            this.radioIsHourlyPay.Text = "Timelønnet";
            this.radioIsHourlyPay.UseVisualStyleBackColor = true;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Items.AddRange(new object[] {
            "Opret service"});
            this.comboService.Location = new System.Drawing.Point(176, 50);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(141, 21);
            this.comboService.TabIndex = 49;
            this.comboService.Text = "Vælg en service";
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Location = new System.Drawing.Point(338, 34);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(0, 13);
            this.lblCaseID.TabIndex = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(312, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Slet valgt service";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioIsHourlyPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.comboCase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceView";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.ServiceView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.ComboBox comboCase;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioIsHourlyPay;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Button btnDelete;
    }
}
