namespace Advokaterne.Views
{
    partial class EducationView
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmployees = new System.Windows.Forms.ComboBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridEducationOngoing = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEducationOngoing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send en medarbejder på videruddannelse/kursus";
            // 
            // comboEmployees
            // 
            this.comboEmployees.FormattingEnabled = true;
            this.comboEmployees.Location = new System.Drawing.Point(43, 57);
            this.comboEmployees.Name = "comboEmployees";
            this.comboEmployees.Size = new System.Drawing.Size(583, 21);
            this.comboEmployees.TabIndex = 1;
            this.comboEmployees.Text = "Vælg en medarbejder";
            this.comboEmployees.SelectedIndexChanged += new System.EventHandler(this.comboEmployees_SelectedIndexChanged);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(43, 162);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(252, 20);
            this.DateStart.TabIndex = 2;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(43, 201);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(252, 20);
            this.DateEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slut dato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Navn på uddannelse";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "GEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridEducationOngoing
            // 
            this.dataGridEducationOngoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEducationOngoing.Location = new System.Drawing.Point(313, 104);
            this.dataGridEducationOngoing.Name = "dataGridEducationOngoing";
            this.dataGridEducationOngoing.Size = new System.Drawing.Size(335, 275);
            this.dataGridEducationOngoing.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(40, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 11;
            // 
            // EducationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridEducationOngoing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.comboEmployees);
            this.Controls.Add(this.label1);
            this.Name = "EducationView";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.EducationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEducationOngoing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEducationOngoing;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
    }
}
