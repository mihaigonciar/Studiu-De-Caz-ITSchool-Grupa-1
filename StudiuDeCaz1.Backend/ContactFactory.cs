namespace StudiuDeCaz1.Backend
{
    public static class ContactFactory
    {
        private static List<Contact> _contactsInternal = [];

        /// <summary>
        /// Colectie de date in care stocam contactele.
        /// </summary>
        public static List<Contact> ContactList => _contactsInternal;

        /// <summary>
        /// Mecanism de creare de contact nou cu date aditionale.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Contact AddNewContact(string name, string phone, string email = "", string address = "", string city = "")
        {
            Contact contact = CreateContact(name, phone)
                .PopulateAdditionalData(email, address, city);

            return contact;
        }

        /// <summary>
        /// Mecanism de creare de contact nou.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Contact CreateContact(string name, string phone)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentNullException(nameof(phone));
            }

            Contact contact = new Contact(name, phone);
            _contactsInternal.Add(contact);

            Sort();

            return contact;
        }

        /// <summary>
        /// Mecanism de populare de date aditionale pentru contact existent.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        public static Contact PopulateAdditionalData(this Contact contact, string email = "", string address = "", string city = "")
        {
            return contact
                .SetEmail(email)
                .SetAddress(address)
                .SetCity(city);
        }

        public static void Sort()
        {
            _contactsInternal = [.. _contactsInternal.OrderBy(x => x.Name)];
        }
    }
}
