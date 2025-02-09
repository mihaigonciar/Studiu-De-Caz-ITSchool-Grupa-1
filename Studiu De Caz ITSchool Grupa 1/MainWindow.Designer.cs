namespace StudiuDeCaz1.Frontend
{
    partial class MainWindow
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
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            AddContactLabelBtn = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 370);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddContactLabelBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(714, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 80);
            panel2.TabIndex = 1;
            // 
            // AddContactLabelBtn
            // 
            AddContactLabelBtn.Dock = DockStyle.Fill;
            AddContactLabelBtn.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            AddContactLabelBtn.ForeColor = Color.White;
            AddContactLabelBtn.Location = new Point(0, 0);
            AddContactLabelBtn.Name = "AddContactLabelBtn";
            AddContactLabelBtn.Padding = new Padding(0, 0, 0, 12);
            AddContactLabelBtn.Size = new Size(86, 80);
            AddContactLabelBtn.TabIndex = 0;
            AddContactLabelBtn.Text = "+";
            AddContactLabelBtn.TextAlign = ContentAlignment.MiddleCenter;
            AddContactLabelBtn.Click += AddContactLabelBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(8);
            label1.Size = new Size(243, 80);
            label1.TabIndex = 0;
            label1.Text = "Agenda Contacte";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label AddContactLabelBtn;
    }
}
