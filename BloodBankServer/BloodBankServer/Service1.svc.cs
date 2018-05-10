using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BloodBankServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void regesterUser(string user, string pas, string BG, string address, int contact)
        {
            AcceptorClass a = new AcceptorClass();
            a.Username1 = user;
            a.Password = pas;
            a.Bloodgroup = BG;
            a.Address = address;
            a.Contact = contact;

            AcceptorDL.acptrList.Add(a);
        }
        public List<AcceptorClass> showAll()
        {
            return AcceptorDL.acptrList;
        }

        public void regesterDonor(string user, string pas, string BG, string address, int contact, Image img, int age, DateTime m)
        {
            DonorClass a = new DonorClass();
            a.Username1 = user;
            a.Password = pas;
            a.Bloodgroup = BG;
            a.Address = address;
            a.Contact = contact;
            a.Age = age;
            a.T = m;
            a.Img = img;
            DonorDL.donoList.Add(a);
        }
        public bool loginDonor(string name, int age, string paswrd)
        {
            bool yes = false;
            foreach (DonorClass r in DonorDL.donoList)
            {
                if (r.Username1 == name && r.Password == paswrd && r.Age == age)
                {
                    yes = true;
                }
            }
            return yes;
        }

        public List<DonorClass> showDonor()
        {
            return DonorDL.donoList;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
