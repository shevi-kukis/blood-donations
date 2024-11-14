using blood_donations.Entities;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckServies
    {
        public DataContext dataContext = ManagerDataContex.DataContex;



        public List<CompatibilityCheck> GetServies()
        {
            return dataContext.CompatibilityChecks;
        }
        public CompatibilityCheck GetByIdServies(int id)
        {
            return dataContext.CompatibilityChecks.FirstOrDefault(c => c.Id == id);

        }
        public bool PostServies(CompatibilityCheck c)
        {
            dataContext.CompatibilityChecks.Add(c);
            return true;
        }
        public bool PutServies(int id, CompatibilityCheck check)
        {
            foreach (CompatibilityCheck c in dataContext.CompatibilityChecks)
            {
                if (c.Id == id)
                {
                    
                    c.IdPatient = check.IdPatient;
                    c.IdBloodeDose = check.IdBloodeDose;
                    c.DateCheck = check.DateCheck;
                    c.NumNeedDose = check.NumNeedDose;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteServies(int id)
        {
            return dataContext.CompatibilityChecks.Remove(dataContext.CompatibilityChecks.FirstOrDefault(c => c.Id == id));
        }

    }
}
