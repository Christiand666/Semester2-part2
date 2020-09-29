namespace Advokaterne
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUR = new System.Windows.Forms.Button();
            this.btnHours = new System.Windows.Forms.Button();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnUR);
            this.panel1.Controls.Add(this.btnHours);
            this.panel1.Controls.Add(this.serviceBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 451);
            this.panel1.TabIndex = 0;
            // 
            // btnUR
            // 
            this.btnUR.Location = new System.Drawing.Point(12, 203);
            this.btnUR.Name = "btnUR";
            this.btnUR.Size = new System.Drawing.Size(111, 23);
            this.btnUR.TabIndex = 4;
            this.btnUR.Text = "Ur";
            this.btnUR.UseVisualStyleBackColor = true;
            this.btnUR.Click += new System.EventHandler(this.btnUR_Click);
            // 
            // btnHours
            // 
            this.btnHours.Location = new System.Drawing.Point(12, 162);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(111, 23);
            this.btnHours.TabIndex = 0;
            this.btnHours.Text = "Indberat timer";
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Location = new System.Drawing.Point(12, 121);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(111, 23);
            this.serviceBtn.TabIndex = 3;
            this.serviceBtn.Text = "Service";
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Efteruddannelse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cases";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ansatte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(133, 0);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(668, 451);
            this.View.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.View);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Advokaternes Portal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel View;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHours;
        private System.Windows.Forms.Button btnUR;
    }
}

