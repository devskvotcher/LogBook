namespace WindowsFormsApp1
{
    partial class EditForm
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
            this.COVID19 = new System.Windows.Forms.ComboBox();
            this.PatientResult = new System.Windows.Forms.ComboBox();
            this.PatientTransferTime = new System.Windows.Forms.DateTimePicker();
            this.PatientAge = new System.Windows.Forms.TextBox();
            this.PatientHistory = new System.Windows.Forms.TextBox();
            this.PatientLastName = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientSurname = new System.Windows.Forms.TextBox();
            this.PatientDeliviry = new System.Windows.Forms.DateTimePicker();
            this.GetDepartment = new System.Windows.Forms.ComboBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // COVID19
            // 
            this.COVID19.FormattingEnabled = true;
            this.COVID19.Location = new System.Drawing.Point(12, 397);
            this.COVID19.Name = "COVID19";
            this.COVID19.Size = new System.Drawing.Size(121, 21);
            this.COVID19.TabIndex = 21;
            // 
            // PatientResult
            // 
            this.PatientResult.FormattingEnabled = true;
            this.PatientResult.Location = new System.Drawing.Point(12, 354);
            this.PatientResult.Name = "PatientResult";
            this.PatientResult.Size = new System.Drawing.Size(121, 21);
            this.PatientResult.TabIndex = 20;
            // 
            // PatientTransferTime
            // 
            this.PatientTransferTime.CustomFormat = "dd-MM-yyyy HH:mm";
            this.PatientTransferTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PatientTransferTime.Location = new System.Drawing.Point(12, 316);
            this.PatientTransferTime.Name = "PatientTransferTime";
            this.PatientTransferTime.Size = new System.Drawing.Size(187, 20);
            this.PatientTransferTime.TabIndex = 19;
            // 
            // PatientAge
            // 
            this.PatientAge.Location = new System.Drawing.Point(12, 179);
            this.PatientAge.Name = "PatientAge";
            this.PatientAge.Size = new System.Drawing.Size(75, 20);
            this.PatientAge.TabIndex = 18;
            // 
            // PatientHistory
            // 
            this.PatientHistory.Location = new System.Drawing.Point(12, 139);
            this.PatientHistory.Name = "PatientHistory";
            this.PatientHistory.Size = new System.Drawing.Size(75, 20);
            this.PatientHistory.TabIndex = 17;
            // 
            // PatientLastName
            // 
            this.PatientLastName.Location = new System.Drawing.Point(12, 96);
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.Size = new System.Drawing.Size(187, 20);
            this.PatientLastName.TabIndex = 16;
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(12, 59);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(187, 20);
            this.PatientName.TabIndex = 15;
            // 
            // PatientSurname
            // 
            this.PatientSurname.Location = new System.Drawing.Point(12, 21);
            this.PatientSurname.Name = "PatientSurname";
            this.PatientSurname.Size = new System.Drawing.Size(187, 20);
            this.PatientSurname.TabIndex = 14;
            // 
            // PatientDeliviry
            // 
            this.PatientDeliviry.CustomFormat = "dd-MM-yyyy HH:mm";
            this.PatientDeliviry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PatientDeliviry.Location = new System.Drawing.Point(12, 230);
            this.PatientDeliviry.Name = "PatientDeliviry";
            this.PatientDeliviry.Size = new System.Drawing.Size(187, 20);
            this.PatientDeliviry.TabIndex = 13;
            // 
            // GetDepartment
            // 
            this.GetDepartment.FormattingEnabled = true;
            this.GetDepartment.Location = new System.Drawing.Point(12, 268);
            this.GetDepartment.Name = "GetDepartment";
            this.GetDepartment.Size = new System.Drawing.Size(121, 21);
            this.GetDepartment.TabIndex = 12;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(296, 397);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 11;
            this.Accept.Text = "Применить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(409, 397);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
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
            this.Controls.Add(this.Accept);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COVID19;
        private System.Windows.Forms.ComboBox PatientResult;
        private System.Windows.Forms.DateTimePicker PatientTransferTime;
        private System.Windows.Forms.TextBox PatientAge;
        private System.Windows.Forms.TextBox PatientHistory;
        private System.Windows.Forms.TextBox PatientLastName;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox PatientSurname;
        private System.Windows.Forms.DateTimePicker PatientDeliviry;
        private System.Windows.Forms.ComboBox GetDepartment;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Exit;
    }
}