using StudiuDeCaz1.Backend;
using System.Diagnostics;

namespace StudiuDeCaz1.Frontend
{
    public partial class ContactCard : UserControl
    {
        public readonly Contact Contact;

        public event EventHandler DoClick;

        public ContactCard(Contact contact)
        {
            InitializeComponent();

            NameLabel.Click += (s, e) => OnClick(e);

            Contact = contact;

            UpdateUI();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            DoClick?.Invoke(this, e);
        }

        private void OnDoClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void UpdateUI()
        {
            if (Contact == null)
            {
                throw new ArgumentNullException(nameof(Contact));
            }

            NameLabel.Text = Contact.Name;
            PhoneLabel.Text = Contact.Phone;
            EmailLabel.Text = Contact.Email;
            CityLabel.Text = Contact.City;
            AddressLabel.Text = Contact.Address;
        }

        private void EmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(Contact.Email)) return;

            string command = $"mailto:{Contact.Email}";
            Process.Start(new ProcessStartInfo(command) { UseShellExecute = true });
        }

        private void PhoneLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(Contact.Phone)) return;

            string command = $"tel:{Contact.Phone}";
            Process.Start(new ProcessStartInfo(command) { UseShellExecute = true });
        }
    }
}
