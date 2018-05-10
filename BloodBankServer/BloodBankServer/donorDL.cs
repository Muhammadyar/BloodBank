using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBankServer
{
    public class donorDL
    {
        public static List<donor> shortlist = new List<donor>();
        public List<donor> searchName(string name)
        {
            List<donor> l = new List<donor>();
            foreach (donor h in donorDL.shortlist)
            {
                if (h.Name == name)
                {

                    l.Add(h);
                }
            }
            return l;
        }
        public List<donor> searchBG(string bg)
        {
            List<donor> l = new List<donor>();
            foreach (donor h in donorDL.shortlist)
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