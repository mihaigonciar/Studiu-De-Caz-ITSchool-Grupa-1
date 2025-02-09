using StudiuDeCaz1.Backend;

namespace StudiuDeCaz1.Frontend
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopulateContactsUI();
        }

        private void PopulateContactsUI()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Contact item in ContactFactory.ContactList)
            {
                ContactCard card = new ContactCard(item);
                card.Dock = DockStyle.Top;
                card.Height = 100;
                card.DoClick += OnContactCardClick;
                card.Padding = new Padding(32, 0, 0, 0);

                flowLayoutPanel1.Controls.Add(card);
            }

            flowLayoutPanel1.Controls[0].Dock = DockStyle.None;

            UpdateFlowControlsWidth();
        }

        private void OnContactCardClick(object? sender, EventArgs e)
        {
            ContactEditor contactForm = new((sender as ContactCard).Contact);

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                PopulateContactsUI();
            }
        }

        private void UpdateFlowControlsWidth()
        {
            if (flowLayoutPanel1.Controls.Count == 0) return;

            flowLayoutPanel1.Controls[0].Width = flowLayoutPanel1.Width - 32;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            UpdateFlowControlsWidth();
        }

        private void AddContactLabelBtn_Click(object sender, EventArgs e)
        {
            ContactEditor contactForm = new ContactEditor();

            contactForm.ShowDialog();

            if (contactForm.DialogResult != DialogResult.OK) return;

            ContactFactory.AddNewContact(
                contactForm.ContactName,
                contactForm.ContactPhone,
                contactForm.ContactEmail,
                contactForm.ContactAddress,
                contactForm.ContactCity
                );

            PopulateContactsUI();
        }
    }
}
