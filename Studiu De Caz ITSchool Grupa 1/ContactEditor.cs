using StudiuDeCaz1.Backend;

namespace StudiuDeCaz1.Frontend
{
    public partial class ContactEditor : Form
    {
        internal string ContactName = string.Empty;
        internal string ContactPhone = string.Empty;
        internal string ContactEmail = string.Empty;
        internal string ContactCity = string.Empty;
        internal string ContactAddress = string.Empty;

        private bool _updateContact;
        private readonly Contact? _targetContact = null;

        public ContactEditor()
        {
            InitializeComponent();

            _updateContact = false;
            Text = "Create New Contact";
            TitleLabel.Text = Text;
        }

        public ContactEditor(Contact contact) : this()
        {
            _targetContact = contact;
            _updateContact = true;

            NameTextBox.Text = _targetContact.Name;
            PhoneTextBox.Text = _targetContact.Phone;
            EmailTextBox.Text = _targetContact.Email;
            CityTextBox.Text = _targetContact.City;
            AddressTextBox.Text = _targetContact.Address;

            Text = "Edit Contact Form";
            TitleLabel.Text = Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                return;
            }

            ContactName = NameTextBox.Text;
            ContactPhone = PhoneTextBox.Text;
            ContactEmail = EmailTextBox.Text;
            ContactCity = CityTextBox.Text;
            ContactAddress = AddressTextBox.Text;

            if (_updateContact)
            {
                _targetContact?
                    .SetName(ContactName)
                    .SetPhone(ContactPhone)
                    .PopulateAdditionalData(ContactEmail, ContactAddress, ContactCity);

                ContactFactory.Sort();
            }

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
