using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{
    public class Customer
    {
        private int uid;
        private string firstName;
        private string lastName;
        private string address;
        private string phone;
        private string birthDate;
        private string gender;
        private string enmergencyName;
        private string enmergencyRelationship;
        private string enmergencyPhone;

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string address, string phone, string birthDate, string gender, string enmergencyName, string enmergencyRelationship, string enmergencyPhone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.birthDate = birthDate;
            this.gender = gender;
            this.enmergencyName = enmergencyName;
            this.enmergencyRelationship = enmergencyRelationship;
            this.enmergencyPhone = enmergencyPhone;
        }

        public Customer(int uid, string firstName, string lastName, string address, string phone, string birthDate, string gender, string enmergencyName, string enmergencyRelationship, string enmergencyPhone)
        {
            this.uid = uid;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.birthDate = birthDate;
            this.gender = gender;
            this.enmergencyName = enmergencyName;
            this.enmergencyRelationship = enmergencyRelationship;
            this.enmergencyPhone = enmergencyPhone;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value != "")
                {
                    firstName = value;
                }
                else
                {
                    throw new CustomerException("First name can not be empty!");
                }
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
                if (value != "")
                {
                    lastName = value;
                }
                else
                {
                    throw new CustomerException("Last name can not be empty!");
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (value != "")
                {
                    address = value;
                }
                else
                {
                    throw new CustomerException("Address can not be empty!");
                }
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
                if (value != "")
                {
                    phone = value;
                }
                else
                {
                    throw new CustomerException("Phone can not be empty!");
                }
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                if (value != "")
                {
                    birthDate = value;
                }
                else
                {
                    throw new CustomerException("Birth Date can not be empty!");
                }
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                if (value != "")
                {
                    gender = value;
                }
                else
                {
                    throw new CustomerException("Gender can not be empty!");
                }
            }
        }

        public string EnmergencyName
        {
            get
            {
                return enmergencyName;
            }

            set
            {
                if (value != "")
                {
                    enmergencyName = value;
                }
                else
                {
                    throw new CustomerException("Enmergency Name can not be empty!");
                }
            }
        }

        public string EnmergencyRelationship
        {
            get
            {
                return enmergencyRelationship;
            }

            set
            {
                if (value != "")
                {
                    enmergencyRelationship = value;
                }
                else
                {
                    throw new CustomerException("Enmergency Relationship can not be empty!");
                }
            }
        }

        public string EnmergencyPhone
        {
            get
            {
                return enmergencyPhone;
            }

            set
            {
                if (value != "")
                {
                    enmergencyPhone = value;
                }
                else
                {
                    throw new CustomerException("Enmergency Phone can not be empty!");
                }
            }
        }

        public int Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }
    }
}
