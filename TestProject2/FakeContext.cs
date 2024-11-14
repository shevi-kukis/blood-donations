using blood_donations;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class FakeContext:IdataContext
    {
        public List<Donor> LoadData()
        {
            Donor donor = new Donor();
            donor.Id = 1;
            donor.IdDonor = "214830655";
            donor.FirstNameDonor = "sag";
            donor.LastNameDonor = "ygu";

            return new List<Donor>() { donor };
        }
        public bool SaveData(List<Donor> data)
        {
            return true;
        }
    }
}
