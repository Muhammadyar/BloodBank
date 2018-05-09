using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace BloodBankServer
{
    public class donor
    {
        private string name;
        private string bloodgroup;
        private int age;
        private int contactNumber;
        private string address;
        private string image;
        private string password;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Bloodgroup
        {
            get
            {
                return bloodgroup;
            }

            set
            {
                bloodgroup = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int ContactNumber
        {
            get
            {
                return contactNumber;
            }

            set
            {
                contactNumber = value;
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

        public string Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}