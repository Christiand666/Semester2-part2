namespace Advokaterne.Views
{
    partial class Watch
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
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimerSan = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(395, 129);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(117, 42);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "København ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "San Francisco";
            // 
            // lblTimerSan
            // 
            this.lblTimerSan.AutoSize = true;
            this.lblTimerSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSan.Location = new System.Drawing.Point(395, 193);
            this.lblTimerSan.Name = "lblTimerSan";
            this.lblTimerSan.Size = new System.Drawing.Size(117, 42);
            this.lblTimerSan.TabIndex = 2;
            this.lblTimerSan.Text = "00:00";
            this.lblTimerSan.Click += new System.EventHandler(this.lblTimerSan_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimerSan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Name = "Watch";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.Watch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimerSan;
        private System.Windows.Forms.Timer timer;
    }
}
