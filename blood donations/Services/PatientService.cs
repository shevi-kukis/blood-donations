using blood_donations.Entities;
using Microsoft.AspNetCore.Mvc;

namespace blood_donations.Servies
{
    public class PatientServies
    {
        public List<Patient> patients { get; set; }
        public List<Patient> GetServies()
        {
            return patients;
        }
        public Patient GetServiesById(string id)
        {
            return patients.FirstOrDefault(e => e.Id == id);
        }
        public ActionResult<bool> PostServies(Patient e)
        {
            patients.Add(e);
            return true;
        }
        public ActionResult<bool> PutServies(string id,Patient patient)
        {
            foreach (Patient p in patients)
            {
                if (p.Id == id)
                {
                    p.Id=patient.Id;
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
        public ActionResult<bool> DeleteServies(string id)
        {
            return patients.Remove(patients.FirstOrDefault(e => e.Id == id));
        }
    }
}