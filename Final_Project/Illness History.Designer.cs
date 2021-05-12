namespace Final_Project
{
    partial class Illness_History
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.immunIDBox = new System.Windows.Forms.TextBox();
            this.patientIDBox = new System.Windows.Forms.TextBox();
            this.deliveryBox = new System.Windows.Forms.TextBox();
            this.commentsBox = new System.Windows.Forms.TextBox();
            this.hcpIDBox = new System.Windows.Forms.TextBox();
            this.deletedCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ImmunizationdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpirationdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vaccineBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ImmunizationID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vaccine:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Immunization Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiration Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Delivery:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comments:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "HCP ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Deleted:";
            // 
            // immunIDBox
            // 
            this.immunIDBox.Location = new System.Drawing.Point(111, 4);
            this.immunIDBox.Name = "immunIDBox";
            this.immunIDBox.Size = new System.Drawing.Size(100, 20);
            this.immunIDBox.TabIndex = 9;
            // 
            // patientIDBox
            // 
            this.patientIDBox.Location = new System.Drawing.Point(86, 41);
            this.patientIDBox.Name = "patientIDBox";
            this.patientIDBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDBox.TabIndex = 10;
            this.patientIDBox.TextChanged += new System.EventHandler(this.patientIDBox_TextChanged);
            // 
            // deliveryBox
            // 
            this.deliveryBox.Location = new System.Drawing.Point(77, 177);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryBox.TabIndex = 14;
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(88, 211);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(100, 20);
            this.commentsBox.TabIndex = 15;
            // 
            // hcpIDBox
            // 
            this.hcpIDBox.Location = new System.Drawing.Point(75, 245);
            this.hcpIDBox.Name = "hcpIDBox";
            this.hcpIDBox.Size = new System.Drawing.Size(100, 20);
            this.hcpIDBox.TabIndex = 16;
            this.hcpIDBox.TextChanged += new System.EventHandler(this.hcpIDBox_TextChanged);
            // 
            // deletedCheckBox
            // 
            this.deletedCheckBox.AutoSize = true;
            this.deletedCheckBox.Location = new System.Drawing.Point(273, 299);
            this.deletedCheckBox.Name = "deletedCheckBox";
            this.deletedCheckBox.Size = new System.Drawing.Size(69, 17);
            this.deletedCheckBox.TabIndex = 17;
            this.deletedCheckBox.Text = "Deleted?";
            this.deletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Undo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ImmunizationdateTimePicker
            // 
            this.ImmunizationdateTimePicker.Location = new System.Drawing.Point(126, 103);
            this.ImmunizationdateTimePicker.Name = "ImmunizationdateTimePicker";
            this.ImmunizationdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ImmunizationdateTimePicker.TabIndex = 22;
            // 
            // ExpirationdateTimePicker
            // 
            this.ExpirationdateTimePicker.Location = new System.Drawing.Point(111, 143);
            this.ExpirationdateTimePicker.Name = "ExpirationdateTimePicker";
            this.ExpirationdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ExpirationdateTimePicker.TabIndex = 23;
            // 
            // vaccineBox
            // 
            this.vaccineBox.Location = new System.Drawing.Point(78, 72);
            this.vaccineBox.Name = "vaccineBox";
            this.vaccineBox.Size = new System.Drawing.Size(100, 20);
            this.vaccineBox.TabIndex = 24;
            // 
            // Illness_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 593);
            this.Controls.Add(this.vaccineBox);
            this.Controls.Add(this.ExpirationdateTimePicker);
            this.Controls.Add(this.ImmunizationdateTimePicker);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletedCheckBox);
            this.Controls.Add(this.hcpIDBox);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.patientIDBox);
            this.Controls.Add(this.immunIDBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Illness_History";
            this.Text = "Illness_History";
            this.Load += new System.EventHandler(this.Illness_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox immunIDBox;
        private System.Windows.Forms.TextBox patientIDBox;
        private System.Windows.Forms.TextBox deliveryBox;
        private System.Windows.Forms.TextBox commentsBox;
        private System.Windows.Forms.TextBox hcpIDBox;
        private System.Windows.Forms.CheckBox deletedCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker ImmunizationdateTimePicker;
        private System.Windows.Forms.DateTimePicker ExpirationdateTimePicker;
        private System.Windows.Forms.TextBox vaccineBox;
    }
}