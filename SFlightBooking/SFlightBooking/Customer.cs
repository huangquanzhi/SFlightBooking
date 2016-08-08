///<summary>
///This class is for creating customer objects
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking {
    public class Customer {
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

        /// <summary>
        /// No argument constructer
        /// </summary>
        public Customer() {

        }

        /// <summary>
        /// Constructor without id as param
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="birthDate"></param>
        /// <param name="gender"></param>
        /// <param name="enmergencyName"></param>
        /// <param name="enmergencyRelationship"></param>
        /// <param name="enmergencyPhone"></param>
        public Customer(string firstName, string lastName, string address, string phone, string birthDate, string gender, string enmergencyName, string enmergencyRelationship, string enmergencyPhone) {
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

        /// <summary>
        /// Constructor with id as param
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="birthDate"></param>
        /// <param name="gender"></param>
        /// <param name="enmergencyName"></param>
        /// <param name="enmergencyRelationship"></param>
        /// <param name="enmergencyPhone"></param>
        public Customer(int uid, string firstName, string lastName, string address, string phone, string birthDate, string gender, string enmergencyName, string enmergencyRelationship, string enmergencyPhone) {
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

        /// <summary>
        /// Getter and Setter for FirstName attribute
        /// </summary>
        public string FirstName {
            get {
                return firstName;
            }

            set {
                if (value != "") {
                    firstName = value;
                } else {
                    throw new CustomerException("First name can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and Setter for LastName attribute
        /// </summary>
        public string LastName {
            get {
                return lastName;
            }

            set {
                if (value != "") {
                    lastName = value;
                } else {
                    throw new CustomerException("Last name can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and Setter for address attrbiute
        /// </summary>
        public string Address {
            get {
                return address;
            }

            set {
                if (value != "") {
                    address = value;
                } else {
                    throw new CustomerException("Address can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and setter for phone attribute
        /// </summary>
        public string Phone {
            get {
                return phone;
            }

            set {
                if (value != "") {
                    phone = value;
                } else {
                    throw new CustomerException("Phone can not be empty!");
                }
            }
        }

        public string BirthDate {
            get {
                return birthDate;
            }

            set {
                if (value != "") {
                    if (Validation.DateValidate(value)) {
                        birthDate = value;
                    } else {
                        throw new CustomerException("Date must be in the format yyyy-mm-dd");
                    }
                } else {
                    throw new CustomerException("Birth Date can not be empty!");
                }
            }
        }
        /// <summary>
        /// Getter and setter for gender attribute
        /// </summary>
        public string Gender {
            get {
                return gender;
            }

            set {
                if (value != "") {
                    gender = value;
                } else {
                    throw new CustomerException("Gender can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and setter for emergencyName attribute
        /// </summary>
        public string EnmergencyName {
            get {
                return enmergencyName;
            }

            set {
                if (value != "") {
                    enmergencyName = value;
                } else {
                    throw new CustomerException("Enmergency Name can not be empty!");
                }
            }
        }

        public string EnmergencyRelationship {
            get {
                return enmergencyRelationship;
            }

            set {
                if (value != "") {
                    enmergencyRelationship = value;
                } else {
                    throw new CustomerException("Enmergency Relationship can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and setter for emergencyphone attribute
        /// </summary>
        public string EnmergencyPhone {
            get {
                return enmergencyPhone;
            }

            set {
                if (value != "") {
                    enmergencyPhone = value;
                } else {
                    throw new CustomerException("Enmergency Phone can not be empty!");
                }
            }
        }

        /// <summary>
        /// Getter and setter for id attribute
        /// </summary>
        public int Uid {
            get {
                return uid;
            }

            set {
                uid = value;
            }
        }
    }
}
