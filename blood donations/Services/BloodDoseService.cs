using blood_donations.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blood_donations.Servies
{
    public class BloodDoseService
    {

        public List<BloodDose> doses = new List<BloodDose>();
        public List<BloodDose> GetServies()
        {
            return doses;
        }
        public BloodDose GetByIdServies(string id)
        {
            return doses.FirstOrDefault(c => c.Id == id);

        }
        public ActionResult<bool> PostServies(BloodDose d)
        {
            doses.Add(d);
            return true;
        }
        public ActionResult<bool> PutServies(string id, BloodDose dose)
        {
            foreach (BloodDose d in doses)
            {
                if (d.Id == id)
                {
                    d.Id = id;
                   d.expirationDate=dose.expirationDate;
                    d.DatOfDonation = d.DatOfDonation;
                    d.IdDonor = d.Id;
                    d.IsTaken = d.IsTaken;
                    d.IsChecked = d.IsChecked;
                    d.bloodType = d.bloodType;
                }
            }
            return false;
        }
        public ActionResult<bool> DeleteServies(string id)
        {
            return doses.Remove(doses.FirstOrDefault(d => d.Id == id));
        }
    }
}
