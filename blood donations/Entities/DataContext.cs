using blood_donations.Subjects;
using System.Drawing;
using System.Text.Json;

namespace blood_donations.Entities
{
    public class DataContext:IdataContext
    {
        public List<Donor> Donors { get; set; }
        public List<Patient> Patients { get; set; }

        public List<Employee> employees { get; set; } 

        public List<BloodDose> bloodDoses { get; set; }

        public List<CompatibilityCheck> CompatibilityChecks { get; set; }

       public List<Donor>LoadData()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data","data.json");


            string jsonString = File.ReadAllText(path);
            var AllDonrs = JsonSerializer.Deserialize<DataDonors>(jsonString);

            return AllDonrs.db;
        }
        public bool SaveData(List<Donor> donors)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");


                DataDonors donor = new DataDonors();
                donor.db = donors;
                string jsonString = JsonSerializer.Serialize<DataDonors>(donor);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
  }

