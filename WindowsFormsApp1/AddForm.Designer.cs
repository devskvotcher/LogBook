namespace WindowsFormsApp1
{
    partial class AddForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.GetDepartment = new System.Windows.Forms.ComboBox();
            this.PatientDeliviry = new System.Windows.Forms.DateTimePicker();
            this.PatientSurname = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientLastName = new System.Windows.Forms.TextBox();
            this.PatientHistory = new System.Windows.Forms.TextBox();
            this.PatientAge = new System.Windows.Forms.TextBox();
            this.PatientTransferTime = new System.Windows.Forms.DateTimePicker();
            this.PatientResult = new System.Windows.Forms.ComboBox();
            this.COVID19 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetDepartment
            // 
            this.GetDepartment.FormattingEnabled = true;
            this.GetDepartment.Location = new System.Drawing.Point(12, 275);
            this.GetDepartment.Name = "GetDepartment";
            this.GetDepartment.Size = new System.Drawing.Size(121, 21);
            this.GetDepartment.TabIndex = 1;
            this.GetDepartment.SelectedIndexChanged += new System.EventHandler(this.GetDepartment_SelectedIndexChanged);
            // 
            // PatientDeliviry
            // 
            this.PatientDeliviry.Location = new System.Drawing.Point(12, 237);
            this.PatientDeliviry.Name = "PatientDeliviry";
            this.PatientDeliviry.Size = new System.Drawing.Size(187, 20);
            this.PatientDeliviry.TabIndex = 2;
            this.PatientDeliviry.ValueChanged += new System.EventHandler(this.PatientDeliviry_ValueChanged);
            // 
            // PatientSurname
            // 
            this.PatientSurname.Location = new System.Drawing.Point(12, 28);
            this.PatientSurname.Name = "PatientSurname";
            this.PatientSurname.Size = new System.Drawing.Size(187, 20);
            this.PatientSurname.TabIndex = 3;
            this.PatientSurname.TextChanged += new System.EventHandler(this.PatientSurname_TextChanged);
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(12, 66);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(187, 20);
            this.PatientName.TabIndex = 4;
            this.PatientName.TextChanged += new System.EventHandler(this.PatientName_TextChanged);
            // 
            // PatientLastName
            // 
            this.PatientLastName.Location = new System.Drawing.Point(12, 103);
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.Size = new System.Drawing.Size(187, 20);
            this.PatientLastName.TabIndex = 5;
            this.PatientLastName.TextChanged += new System.EventHandler(this.PatientLastName_TextChanged);
            // 
            // PatientHistory
            // 
            this.PatientHistory.Location = new System.Drawing.Point(12, 146);
            this.PatientHistory.Name = "PatientHistory";
            this.PatientHistory.Size = new System.Drawing.Size(75, 20);
            this.PatientHistory.TabIndex = 6;
            this.PatientHistory.TextChanged += new System.EventHandler(this.PatientHistory_TextChanged);
            // 
            // PatientAge
            // 
            this.PatientAge.Location = new System.Drawing.Point(12, 186);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.Size = new System.Drawing.Size(75, 20);
            this.PatientAge.TabIndex = 7;
            this.PatientAge.TextChanged += new System.EventHandler(this.PatientAge_TextChanged);
            // 
            // PatientTransferTime
            // 
            this.PatientTransferTime.Location = new System.Drawing.Point(12, 323);
            this.PatientTransferTime.Name = "PatientTransferTime";
            this.PatientTransferTime.Size = new System.Drawing.Size(187, 20);
            this.PatientTransferTime.TabIndex = 8;
            this.PatientTransferTime.ValueChanged += new System.EventHandler(this.PatientTransferTime_ValueChanged);
            // 
            // PatientResult
            // 
            this.PatientResult.FormattingEnabled = true;
            this.PatientResult.Location = new System.Drawing.Point(12, 361);
            this.PatientResult.Name = "PatientResult";
            this.PatientResult.Size = new System.Drawing.Size(121, 21);
            this.PatientResult.TabIndex = 9;
            this.PatientResult.SelectedIndexChanged += new System.EventHandler(this.PatientResult_SelectedIndexChanged);
            // 
            // COVID19
            // 
            this.COVID19.FormattingEnabled = true;
            this.COVID19.Location = new System.Drawing.Point(12, 404);
            this.COVID19.Name = "COVID19";
            this.COVID19.Size = new System.Drawing.Size(121, 21);
            this.COVID19.TabIndex = 10;
            this.COVID19.SelectedIndexChanged += new System.EventHandler(this.COVID19_SelectedIndexChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.COVID19);
            this.Controls.Add(this.PatientResult);
            this.Controls.Add(this.PatientTransferTime);
            this.Controls.Add(this.PatientAge);
            this.Controls.Add(this.PatientHistory);
            this.Controls.Add(this.PatientLastName);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.PatientSurname);
            this.Controls.Add(this.PatientDeliviry);
            this.Controls.Add(this.GetDepartment);
            this.Controls.Add(this.button1);
            this.Name = "AddForm";
            this.Text = "Добавление пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GetDepartment;
        private System.Windows.Forms.DateTimePicker PatientDeliviry;
        private System.Windows.Forms.TextBox PatientSurname;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox PatientLastName;
        private System.Windows.Forms.TextBox PatientHistory;
        private System.Windows.Forms.TextBox PatientAge;
        private System.Windows.Forms.DateTimePicker PatientTransferTime;
        private System.Windows.Forms.ComboBox PatientResult;
        private System.Windows.Forms.ComboBox COVID19;
    }
}