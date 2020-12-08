namespace ContactsAppsUI
{
    partial class Edit_Form
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
            this.ContactDataTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MaskedPhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VKidTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.VKidLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.BirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ContactDataTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactDataTableLayout
            // 
            this.ContactDataTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactDataTableLayout.ColumnCount = 2;
            this.ContactDataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.ContactDataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.ContactDataTableLayout.Controls.Add(this.MaskedPhoneTextBox, 1, 3);
            this.ContactDataTableLayout.Controls.Add(this.VKidTextBox, 1, 5);
            this.ContactDataTableLayout.Controls.Add(this.EmailTextBox, 1, 4);
            this.ContactDataTableLayout.Controls.Add(this.NameTextBox, 1, 1);
            this.ContactDataTableLayout.Controls.Add(this.LastnameTextBox, 1, 0);
            this.ContactDataTableLayout.Controls.Add(this.NameLabel, 0, 1);
            this.ContactDataTableLayout.Controls.Add(this.BirthdateLabel, 0, 2);
            this.ContactDataTableLayout.Controls.Add(this.PhoneLabel, 0, 3);
            this.ContactDataTableLayout.Controls.Add(this.EmailLabel, 0, 4);
            this.ContactDataTableLayout.Controls.Add(this.VKidLabel, 0, 5);
            this.ContactDataTableLayout.Controls.Add(this.LastnameLabel, 0, 0);
            this.ContactDataTableLayout.Controls.Add(this.BirthdateDateTimePicker, 1, 2);
            this.ContactDataTableLayout.Location = new System.Drawing.Point(12, 12);
            this.ContactDataTableLayout.Name = "ContactDataTableLayout";
            this.ContactDataTableLayout.RowCount = 6;
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.ContactDataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContactDataTableLayout.Size = new System.Drawing.Size(460, 201);
            this.ContactDataTableLayout.TabIndex = 9;
            // 
            // MaskedPhoneTextBox
            // 
            this.MaskedPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskedPhoneTextBox.Location = new System.Drawing.Point(113, 105);
            this.MaskedPhoneTextBox.Mask = "+70000000000";
            this.MaskedPhoneTextBox.Name = "MaskedPhoneTextBox";
            this.MaskedPhoneTextBox.Size = new System.Drawing.Size(344, 20);
            this.MaskedPhoneTextBox.TabIndex = 14;
            // 
            // VKidTextBox
            // 
            this.VKidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VKidTextBox.Location = new System.Drawing.Point(113, 173);
            this.VKidTextBox.Name = "VKidTextBox";
            this.VKidTextBox.Size = new System.Drawing.Size(344, 20);
            this.VKidTextBox.TabIndex = 15;
            this.VKidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(113, 138);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(344, 20);
            this.EmailTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(113, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(344, 20);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastnameTextBox.Location = new System.Drawing.Point(113, 6);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(344, 20);
            this.LastnameTextBox.TabIndex = 10;
            this.LastnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BanSpecialSymbols);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(58, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdateLabel.Location = new System.Drawing.Point(38, 74);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(69, 17);
            this.BirthdateLabel.TabIndex = 2;
            this.BirthdateLabel.Text = "Birthdate:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(54, 107);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 17);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(56, 140);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail:";
            // 
            // VKidLabel
            // 
            this.VKidLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VKidLabel.AutoSize = true;
            this.VKidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKidLabel.Location = new System.Drawing.Point(51, 174);
            this.VKidLabel.Name = "VKidLabel";
            this.VKidLabel.Size = new System.Drawing.Size(56, 17);
            this.VKidLabel.TabIndex = 5;
            this.VKidLabel.Text = "vk.com:";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastnameLabel.Location = new System.Drawing.Point(25, 8);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(82, 17);
            this.LastnameLabel.TabIndex = 0;
            this.LastnameLabel.Text = "LastnameL:";
            // 
            // BirthdateDateTimePicker
            // 
            this.BirthdateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirthdateDateTimePicker.Location = new System.Drawing.Point(113, 72);
            this.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker";
            this.BirthdateDateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.BirthdateDateTimePicker.TabIndex = 16;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(315, 220);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 10;
            this.AcceptButton.Text = "OK";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(394, 220);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ContactDataTableLayout);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Edit_Form";
            this.Text = "Edit_Form";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            this.ContactDataTableLayout.ResumeLayout(false);
            this.ContactDataTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContactDataTableLayout;
        private System.Windows.Forms.TextBox VKidTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label VKidLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.DateTimePicker BirthdateDateTimePicker;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.MaskedTextBox MaskedPhoneTextBox;
    }
}