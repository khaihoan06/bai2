namespace bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.CheckBox cbLaptop;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            lblTicketId = new Label();
            txtTicketId = new TextBox();
            lblRequester = new Label();
            txtRequester = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            grpPriority = new GroupBox();
            rbLow = new RadioButton();
            rbNormal = new RadioButton();
            rbHigh = new RadioButton();
            lblType = new Label();
            cmbType = new ComboBox();
            lblDevices = new Label();
            cbDesktop = new CheckBox();
            cbLaptop = new CheckBox();
            cbPrinter = new CheckBox();
            cbPhone = new CheckBox();
            picError = new PictureBox();
            btnLoadImage = new Button();
            btnSubmit = new Button();
            btnReset = new Button();
            grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picError).BeginInit();
            SuspendLayout();
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(12, 15);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(90, 25);
            lblTicketId.TabIndex = 0;
            lblTicketId.Text = "Mã phiếu:";
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(144, 15);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(200, 31);
            txtTicketId.TabIndex = 1;
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Location = new Point(12, 50);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(131, 25);
            lblRequester.TabIndex = 2;
            lblRequester.Text = "Người yêu cầu:";
            // 
            // txtRequester
            // 
            txtRequester.Location = new Point(144, 50);
            txtRequester.Name = "txtRequester";
            txtRequester.Size = new Size(200, 31);
            txtRequester.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 86);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(132, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Ngày ghi nhận:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(144, 83);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 31);
            dtpDate.TabIndex = 5;
            // 
            // grpPriority
            // 
            grpPriority.Controls.Add(rbLow);
            grpPriority.Controls.Add(rbNormal);
            grpPriority.Controls.Add(rbHigh);
            grpPriority.Location = new Point(12, 120);
            grpPriority.Name = "grpPriority";
            grpPriority.Size = new Size(332, 55);
            grpPriority.TabIndex = 6;
            grpPriority.TabStop = false;
            grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rbLow
            // 
            rbLow.AutoSize = true;
            rbLow.Location = new Point(10, 22);
            rbLow.Name = "rbLow";
            rbLow.Size = new Size(76, 29);
            rbLow.TabIndex = 0;
            rbLow.TabStop = true;
            rbLow.Text = "Thấp";
            rbLow.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(110, 22);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(121, 29);
            rbNormal.TabIndex = 1;
            rbNormal.TabStop = true;
            rbNormal.Text = "Trung bình";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            rbHigh.AutoSize = true;
            rbHigh.Location = new Point(210, 22);
            rbHigh.Name = "rbHigh";
            rbHigh.Size = new Size(109, 29);
            rbHigh.TabIndex = 2;
            rbHigh.TabStop = true;
            rbHigh.Text = "Khẩn cấp";
            rbHigh.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 190);
            lblType.Name = "lblType";
            lblType.Size = new Size(96, 25);
            lblType.TabIndex = 7;
            lblType.Text = "Loại sự cố:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cmbType.Location = new Point(110, 186);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 33);
            cmbType.TabIndex = 8;
            // 
            // lblDevices
            // 
            lblDevices.AutoSize = true;
            lblDevices.Location = new Point(12, 225);
            lblDevices.Name = "lblDevices";
            lblDevices.Size = new Size(166, 25);
            lblDevices.TabIndex = 9;
            lblDevices.Text = "Thiết bị ảnh hưởng:";
            // 
            // cbDesktop
            // 
            cbDesktop.AutoSize = true;
            cbDesktop.Location = new Point(20, 250);
            cbDesktop.Name = "cbDesktop";
            cbDesktop.Size = new Size(142, 29);
            cbDesktop.TabIndex = 10;
            cbDesktop.Text = "Máy tính bàn";
            cbDesktop.UseVisualStyleBackColor = true;
            // 
            // cbLaptop
            // 
            cbLaptop.AutoSize = true;
            cbLaptop.Location = new Point(168, 250);
            cbLaptop.Name = "cbLaptop";
            cbLaptop.Size = new Size(94, 29);
            cbLaptop.TabIndex = 11;
            cbLaptop.Text = "Laptop";
            cbLaptop.UseVisualStyleBackColor = true;
            // 
            // cbPrinter
            // 
            cbPrinter.AutoSize = true;
            cbPrinter.Location = new Point(173, 297);
            cbPrinter.Name = "cbPrinter";
            cbPrinter.Size = new Size(91, 29);
            cbPrinter.TabIndex = 12;
            cbPrinter.Text = "Máy in";
            cbPrinter.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            cbPhone.AutoSize = true;
            cbPhone.Location = new Point(22, 297);
            cbPhone.Name = "cbPhone";
            cbPhone.Size = new Size(119, 29);
            cbPhone.TabIndex = 13;
            cbPhone.Text = "Điện thoại";
            cbPhone.UseVisualStyleBackColor = true;
            // 
            // picError
            // 
            picError.BorderStyle = BorderStyle.FixedSingle;
            picError.Location = new Point(368, 12);
            picError.Name = "picError";
            picError.Size = new Size(420, 300);
            picError.SizeMode = PictureBoxSizeMode.StretchImage;
            picError.TabIndex = 14;
            picError.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(350, 325);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(120, 35);
            btnLoadImage.TabIndex = 15;
            btnLoadImage.Text = "Tải ảnh lỗi";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(650, 325);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 35);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Gửi yêu cầu";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(507, 325);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 33);
            btnReset.TabIndex = 17;
            btnReset.Text = "Nhập lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(btnLoadImage);
            Controls.Add(picError);
            Controls.Add(cbPhone);
            Controls.Add(cbPrinter);
            Controls.Add(cbLaptop);
            Controls.Add(cbDesktop);
            Controls.Add(lblDevices);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(grpPriority);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtRequester);
            Controls.Add(lblRequester);
            Controls.Add(txtTicketId);
            Controls.Add(lblTicketId);
            Name = "Form1";
            Text = "IT Support Ticket";
            grpPriority.ResumeLayout(false);
            grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picError).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}
