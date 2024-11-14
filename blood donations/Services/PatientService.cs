using blood_donations.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blood_donations.Servies
{
    public class PatientServies
    {
        public DataContext dataContext = ManagerDataContex.DataContex;

        public List<Patient> GetServies()
        {
            return dataContext.Patients;
        }
        public Patient GetServiesById(int id)
        {
            return dataContext.Patients.FirstOrDefault(e => e.Id == id);
        }
        public bool PostServies(Patient e)
        {
            dataContext.Patients.Add(e);
            return true;
        }
        public bool PutServies(int id,Patient patient)
        {
            foreach (Patient p in dataContext.Patients)
            {
                if (p.Id == id)
                {
                   
                    p.Origin = patient.Origin;
                    p.sex = patient.sex;
                    p.IdPatient = patient.IdPatient;
                    p.AddressPatient = patient.AddressPatient;
                    p.BirthDate = patient.BirthDate;
                    p.LastNamePatient = patient.LastNamePatient;
                    p.FirstNamePatient = patient.FirstNamePatient;
                    p.levelOfUrgency = patient.levelOfUrgency;
                    p.healthFund = patient.healthFund;

                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return dataContext.Patients.Remove(dataContext.Patients.FirstOrDefault(e => e.Id == id));
        }
    }
}