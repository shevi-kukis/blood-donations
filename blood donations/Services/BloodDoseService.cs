using blood_donations.Entities;
using Coins.server.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace blood_donations.Servies
{
    public class BloodDoseService
    {
        public DataContext dataContext = ManagerDataContex.DataContex;


        public List<BloodDose> GetServies()
        {
            return dataContext.bloodDoses;
        }
        public BloodDose GetByIdService(int id)
        {
            return  dataContext.bloodDoses.FirstOrDefault(b => b.Id == id);

        }
        public bool PostServies(BloodDose d)
        {
            dataContext.bloodDoses.Add(d);
            return true;
        }
        public bool PutServies(int id, BloodDose dose)
        {
            foreach (BloodDose d in dataContext.bloodDoses)
            {
                if (d.Id == id)
                {
                   
                   d.expirationDate=dose.expirationDate;
                    d.DatOfDonation = d.DatOfDonation;
                    d.IdDonor = d.IdDonor;
                    d.IsTaken = d.IsTaken;
                    d.IsChecked = d.IsChecked;
                    d.bloodType = d.bloodType;
                    return false;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return  dataContext.bloodDoses.Remove(dataContext.bloodDoses.FirstOrDefault(d => d.Id == id));
        }
    }
}
