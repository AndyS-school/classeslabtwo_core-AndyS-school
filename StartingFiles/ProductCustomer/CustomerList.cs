using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using [filename] or CustomerMainteneance.[filename]

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public void Add(Customer product)
        {
            customers.Add(product);
        }

        public void Add(string custEmail, string custFirstName, int custId, string custLastName, string custPhone)
        {
            Customer p = new Customer(custEmail, custFirstName, custId, custLastName, custPhone);
            customers.Add(p);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer p in customers)
            {
                output += p.ToString() + "\n";
            }
            return output;
        }

        //indexer
        public Customer this[int i]
        {
            get
            {
                if (i < 0 || i >= customers.Count)
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        public Customer this[string email]
        {
            get
            {
                foreach (Customer p in customers)
                {
                    if (p.Email == email)
                        return p;
                }
                return null;
            }
        }

        public static CustomerList operator +(CustomerList pl, Customer p)
        {
            pl.Add(p);
            return pl;
        }

        public static CustomerList operator -(CustomerList pl, Customer p)
        {
            pl.Remove(p);
            return pl;
        }
    }
}
