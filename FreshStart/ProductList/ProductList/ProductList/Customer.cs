using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        private string email;
        private string firstName;
        private int id;
        private string lastName;
        private string phone;

        public Customer() { }

        public Customer(string custEmail, string custFirstName, int custId, string custLastName, string custPhone)
        {
            this.email = custEmail;
            this.firstName = custFirstName;
            this.id = custId;
            this.lastName = custLastName;
            this.phone = custPhone;
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

            public override string ToString()
        {
            return String.Format("email: {0} First Name: {1} Id: {2} Last Name: {3:C} Phone Number: {4}", email, firstName, Id, lastName, phone);
        }
    
    }
}
