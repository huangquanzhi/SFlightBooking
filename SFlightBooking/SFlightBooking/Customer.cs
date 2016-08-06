using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{
    class Customer
    {

        string firstName;
        string lastName;
        string address;
        string phone;
        string birthDate;
        string gender;
        string enmergencyName;
        string enmergencyRelationship;
        string enmergencyPhone;

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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
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

        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
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
                gender = value;
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
                enmergencyName = value;
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
                enmergencyRelationship = value;
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
                enmergencyPhone = value;
            }
        }
    }
}
