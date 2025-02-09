namespace StudiuDeCaz1.Frontend
{
    partial class ContactEditor
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
            Label NameLabel;
            Label PhoneLabel;
            Label EmailLabel;
            Label CityLabel;
            Label AddressLabel;
            NameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            CityTextBox = new TextBox();
            AddressTextBox = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            SubmitButton = new Button();
            CancelButton = new Button();
            panel1 = new Panel();
            TitleLabel = new Label();
            panel2 = new Panel();
            NameLabel = new Label();
            PhoneLabel = new Label();
            EmailLabel = new Label();
            CityLabel = new Label();
            AddressLabel = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(175, 36);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Dock = DockStyle.Fill;
            PhoneLabel.Location = new Point(3, 36);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(175, 36);
            PhoneLabel.TabIndex = 3;
            PhoneLabel.Text = "Phone";
            PhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailLabel
            // 
            EmailLabel.Dock = DockStyle.Fill;
            EmailLabel.Location = new Point(3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(175, 36);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email";
            EmailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CityLabel
            // 
            CityLabel.Dock = DockStyle.Fill;
            CityLabel.Location = new Point(3, 36);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(175, 36);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            CityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddressLabel
            // 
            AddressLabel.Dock = DockStyle.Fill;
            AddressLabel.Location = new Point(3, 72);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(175, 39);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "Address";
            AddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(184, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(266, 29);
            NameTextBox.TabIndex = 0;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PhoneTextBox.Location = new Point(184, 39);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(266, 29);
            PhoneTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(184, 3);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(266, 29);
            EmailTextBox.TabIndex = 2;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(184, 39);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(266, 29);
            CityTextBox.TabIndex = 3;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(184, 77);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(266, 29);
            AddressTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Needed";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(PhoneLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(PhoneTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(453, 72);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(12, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(459, 139);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Optional";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(AddressLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(CityLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(EmailLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(EmailTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(CityTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(AddressTextBox, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(453, 111);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SubmitButton.Location = new Point(405, 268);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(324, 268);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(TitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 80);
            panel1.TabIndex = 9;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Left;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(265, 80);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Add New Contact";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(SubmitButton);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 294);
            panel2.TabIndex = 10;
            // 
            // ContactEditor
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 374);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ContactEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Contact";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox CityTextBox;
        private TextBox AddressTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button SubmitButton;
        private Button CancelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label TitleLabel;
        private Panel panel2;
    }
}