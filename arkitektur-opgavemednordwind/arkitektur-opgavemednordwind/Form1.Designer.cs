namespace arkitektur_opgavemednordwind
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
            this.text_CustId = new System.Windows.Forms.TextBox();
            this.bt_select = new System.Windows.Forms.Button();
            this.text_custName = new System.Windows.Forms.TextBox();
            this.Bt_update = new System.Windows.Forms.Button();
            this.bt_trans_update = new System.Windows.Forms.Button();
            this.txt_trans = new System.Windows.Forms.TextBox();
            this.bt_trans_select = new System.Windows.Forms.Button();
            this.txt_trans_custid = new System.Windows.Forms.TextBox();
            this.bt_trans_begin = new System.Windows.Forms.Button();
            this.bt_commit = new System.Windows.Forms.Button();
            this.bt_trans_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_CustId
            // 
            this.text_CustId.Location = new System.Drawing.Point(30, 28);
            this.text_CustId.Name = "text_CustId";
            this.text_CustId.Size = new System.Drawing.Size(100, 20);
            this.text_CustId.TabIndex = 0;
            this.text_CustId.Text = "ALFKI";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(30, 54);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 1;
            this.bt_select.Text = "Læs";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // text_custName
            // 
            this.text_custName.Location = new System.Drawing.Point(30, 93);
            this.text_custName.Name = "text_custName";
            this.text_custName.Size = new System.Drawing.Size(196, 20);
            this.text_custName.TabIndex = 2;
            // 
            // Bt_update
            // 
            this.Bt_update.Location = new System.Drawing.Point(30, 119);
            this.Bt_update.Name = "Bt_update";
            this.Bt_update.Size = new System.Drawing.Size(75, 23);
            this.Bt_update.TabIndex = 3;
            this.Bt_update.Text = "Gem";
            this.Bt_update.UseVisualStyleBackColor = true;
            this.Bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // bt_trans_update
            // 
            this.bt_trans_update.Location = new System.Drawing.Point(373, 158);
            this.bt_trans_update.Name = "bt_trans_update";
            this.bt_trans_update.Size = new System.Drawing.Size(75, 23);
            this.bt_trans_update.TabIndex = 7;
            this.bt_trans_update.Text = "Gem";
            this.bt_trans_update.UseVisualStyleBackColor = true;
            this.bt_trans_update.Click += new System.EventHandler(this.bt_trans_update_Click);
            // 
            // txt_trans
            // 
            this.txt_trans.Location = new System.Drawing.Point(373, 132);
            this.txt_trans.Name = "txt_trans";
            this.txt_trans.Size = new System.Drawing.Size(196, 20);
            this.txt_trans.TabIndex = 6;
            // 
            // bt_trans_select
            // 
            this.bt_trans_select.Location = new System.Drawing.Point(373, 93);
            this.bt_trans_select.Name = "bt_trans_select";
            this.bt_trans_select.Size = new System.Drawing.Size(75, 23);
            this.bt_trans_select.TabIndex = 5;
            this.bt_trans_select.Text = "Læs";
            this.bt_trans_select.UseVisualStyleBackColor = true;
            this.bt_trans_select.Click += new System.EventHandler(this.bt_trans_select_Click);
            // 
            // txt_trans_custid
            // 
            this.txt_trans_custid.Location = new System.Drawing.Point(373, 67);
            this.txt_trans_custid.Name = "txt_trans_custid";
            this.txt_trans_custid.Size = new System.Drawing.Size(100, 20);
            this.txt_trans_custid.TabIndex = 4;
            this.txt_trans_custid.Text = "ALFKI";
            // 
            // bt_trans_begin
            // 
            this.bt_trans_begin.Location = new System.Drawing.Point(337, 28);
            this.bt_trans_begin.Name = "bt_trans_begin";
            this.bt_trans_begin.Size = new System.Drawing.Size(176, 23);
            this.bt_trans_begin.TabIndex = 8;
            this.bt_trans_begin.Text = "Start Transaktion";
            this.bt_trans_begin.UseVisualStyleBackColor = true;
            this.bt_trans_begin.Click += new System.EventHandler(this.bt_trans_begin_Click);
            // 
            // bt_commit
            // 
            this.bt_commit.Location = new System.Drawing.Point(337, 203);
            this.bt_commit.Name = "bt_commit";
            this.bt_commit.Size = new System.Drawing.Size(176, 23);
            this.bt_commit.TabIndex = 9;
            this.bt_commit.Text = "Commit";
            this.bt_commit.UseVisualStyleBackColor = true;
            this.bt_commit.Click += new System.EventHandler(this.bt_commit_Click);
            // 
            // bt_trans_reset
            // 
            this.bt_trans_reset.Location = new System.Drawing.Point(337, 232);
            this.bt_trans_reset.Name = "bt_trans_reset";
            this.bt_trans_reset.Size = new System.Drawing.Size(176, 23);
            this.bt_trans_reset.TabIndex = 10;
            this.bt_trans_reset.Text = "Nulstil";
            this.bt_trans_reset.UseVisualStyleBackColor = true;
            this.bt_trans_reset.Click += new System.EventHandler(this.bt_trans_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_trans_reset);
            this.Controls.Add(this.bt_commit);
            this.Controls.Add(this.bt_trans_begin);
            this.Controls.Add(this.bt_trans_update);
            this.Controls.Add(this.txt_trans);
            this.Controls.Add(this.bt_trans_select);
            this.Controls.Add(this.txt_trans_custid);
            this.Controls.Add(this.Bt_update);
            this.Controls.Add(this.text_custName);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.text_CustId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_CustId;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.TextBox text_custName;
        private System.Windows.Forms.Button Bt_update;
        private System.Windows.Forms.Button bt_trans_update;
        private System.Windows.Forms.TextBox txt_trans;
        private System.Windows.Forms.Button bt_trans_select;
        private System.Windows.Forms.TextBox txt_trans_custid;
        private System.Windows.Forms.Button bt_trans_begin;
        private System.Windows.Forms.Button bt_commit;
        private System.Windows.Forms.Button bt_trans_reset;
    }
}

