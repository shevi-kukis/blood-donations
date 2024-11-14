using blood_donations.Entities;
using blood_donations.Subjects;
using Coins.server.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Drawing;

namespace blood_donations.Servies
{
    public class DonorService
    {

     readonly IdataContext _dataContext;

        public DonorService(IdataContext dataContext)
        {
          _dataContext = dataContext;
        }
      
        public List<Donor> GetServies()
        {
            var Donors = _dataContext.LoadData();
           return Donors;
            //return Donors.Select(d => d.Id).ToList();
        }
        public Donor GetServiesById(int id)
        {
            var Donors = _dataContext.LoadData();
            return Donors.Where(d => d.Id == id).FirstOrDefault();
        }
        public bool PostServies(Donor donor)
        {
            var Donors = _dataContext.LoadData();
              Donors.Add(donor);
            return _dataContext.SaveData(Donors);
        }
        public bool PutServies(int id,Donor donor)
        {

            var Donors = _dataContext.LoadData();

            foreach (Donor d in Donors)
            {
                if (d.Id == id)
                {
                    d.IdDonor = donor.IdDonor;
                    d.LastNameDonor = donor.LastNameDonor;
                    d.FirstNameDonor = donor.FirstNameDonor;
                    d.EmailDonor = donor.EmailDonor;
                    d.AddressDonor = donor.AddressDonor;
                    d.BirthDate= donor.BirthDate;
                    d.sex = donor.sex;
                    d.Origin= donor.Origin;
                    d.healthFund= donor.healthFund;
                    return _dataContext.SaveData(Donors);

                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            var Donors = _dataContext.LoadData();

             Donors.Remove(Donors.FirstOrDefault(d=>d.Id == id));
            return _dataContext.SaveData(Donors);
        }

    }
}
