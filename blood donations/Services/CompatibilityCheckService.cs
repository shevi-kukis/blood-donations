using blood_donations.Entities;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace blood_donations.Servies
{
    public class CompatibilityCheckServies
    {
        public List<CompatibilityCheck> checks = new List<CompatibilityCheck>();
        public List<CompatibilityCheck> GetServies()
        {
            return checks;
        }
        public CompatibilityCheck GetByIdServies(string id)
        {
            return checks.FirstOrDefault(c => c.Id == id);

        }
        public ActionResult<bool> PostServies(CompatibilityCheck c)
        {
            checks.Add(c);
            return true;
        }
        public ActionResult<bool> PutServies(string id, CompatibilityCheck check)
        {
            foreach (CompatibilityCheck c in checks)
            {
                if (c.Id == id)
                {
                    c.Id = id;
                    c.IdPatient = check.IdPatient;
                    c.IdBloodeDose = check.IdBloodeDose;
                    c.DateCheck = check.DateCheck;
                    c.NumNeedDose = check.NumNeedDose;
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> DeleteServies(string id)
        {
            return checks.Remove(checks.FirstOrDefault(c => c.Id == id));
        }

    }
}
