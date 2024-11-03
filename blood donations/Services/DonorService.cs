using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Drawing;

namespace blood_donations.Servies
{
    public class DonorServies
    {

        
        public List<Donor> Donors { get; set; }
        public List<Donor> GetServies   ()
        {
           return Donors;
        }
        public Donor  GetServiesById(string id)
        {
        return Donors.FirstOrDefault(d=>d.Id==id);
        }
        public ActionResult<bool> PostServies(Donor donor)
        {
            Donors.Add(donor);
            return true;
        }
        public ActionResult<bool> PutServies(string id,Donor donor)
        {
            foreach(Donor d in  Donors)
            {
                if (d.Id == id)
                {
                    d.Id=donor.Id;
                    d.IdDonor = donor.IdDonor;
                    d.LastNameDonor = donor.LastNameDonor;
                    d.FirstNameDonor = donor.FirstNameDonor;
                    d.EmailDonor = donor.EmailDonor;
                    d.AddressDonor = donor.AddressDonor;
                    d.BirthDate= donor.BirthDate;
                    d.sex = donor.sex;
                    d.Origin= donor.Origin;
                    d.healthFund= donor.healthFund;
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> DeleteServies(string id)
        {
           return Donors.Remove( Donors.FirstOrDefault(d=>d.Id == id));
        }

    }
}
