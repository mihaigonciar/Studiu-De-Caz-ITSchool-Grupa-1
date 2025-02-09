namespace StudiuDeCaz1.Frontend
{
    partial class ContactCard
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
            NameLabel = new Label();
            AddressLabel = new Label();
            CityLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            EmailLabel = new LinkLabel();
            PhoneLabel = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.Teal;
            tableLayoutPanel1.SetColumnSpan(NameLabel, 2);
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(0, 0);
            NameLabel.Margin = new Padding(0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(551, 46);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "<name>";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddressLabel
            // 
            AddressLabel.Dock = DockStyle.Fill;
            AddressLabel.Font = new Font("Segoe UI", 12F);
            AddressLabel.Location = new Point(333, 69);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(215, 35);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "<address>";
            AddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CityLabel
            // 
            CityLabel.Dock = DockStyle.Fill;
            CityLabel.Font = new Font("Segoe UI", 12F);
            CityLabel.Location = new Point(333, 46);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(215, 23);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "<city>";
            CityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(AddressLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(CityLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EmailLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(PhoneLabel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(551, 104);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // EmailLabel
            // 
            EmailLabel.Dock = DockStyle.Fill;
            EmailLabel.Font = new Font("Segoe UI", 12F);
            EmailLabel.Location = new Point(3, 46);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(324, 23);
            EmailLabel.TabIndex = 5;
            EmailLabel.TabStop = true;
            EmailLabel.Text = "<email>";
            EmailLabel.TextAlign = ContentAlignment.MiddleLeft;
            EmailLabel.LinkClicked += EmailLabel_LinkClicked;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Dock = DockStyle.Fill;
            PhoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PhoneLabel.Location = new Point(3, 69);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(324, 35);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.TabStop = true;
            PhoneLabel.Text = "<phone>";
            PhoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            PhoneLabel.LinkClicked += PhoneLabel_LinkClicked;
            // 
            // ContactCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ContactCard";
            Size = new Size(551, 104);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label NameLabel;
        private Label AddressLabel;
        private Label CityLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private LinkLabel EmailLabel;
        private LinkLabel PhoneLabel;
    }
}
