namespace StudiuDeCaz1.Backend
{
    public sealed class Contact
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;

        internal Contact(string name, string phone) 
        {
            Name = name;
            Phone = phone;
        }

        public Contact SetName(string name)
        {
            Name = name;
            return this;
        }

        public Contact SetEmail(string email) 
        {
            Email = email;
            return this;
        }

        public Contact SetPhone(string phone) 
        {
            Phone = phone;
            return this;
        }

        public Contact SetAddress(string address) 
        {
            Address = address;
            return this;
        }

        public Contact SetCity(string city) 
        {
            this.City = city;
            return this;
        }
    }
}
