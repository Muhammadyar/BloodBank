using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBankServer
{
    public class donorDL
    {
        public static List<donor> shortlist = new List<donor>();
        public List<DonorClass> searchName(string name)
        {
            List<DonorClass> l = new List<DonorClass>();
            foreach (DonorClass h in donoList)
            {
                if (h.Username1 == name)
                {
                    l.Add(h);
                }
            }
            return l;
        }
        public List<DonorClass> searchBG(string bg)
        {
            List<DonorClass> l = new List<DonorClass>();
            foreach (DonorClass h in donoList)
            {
                if (h.Bloodgroup == bg)
                {
                    l.Add(h);
                }
            }
            return l;
        }
    }
}