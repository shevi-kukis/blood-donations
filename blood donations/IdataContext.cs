using blood_donations.Subjects;

namespace blood_donations
{
    public interface IdataContext
    {
        public List<Donor> LoadData();
        public bool SaveData(List<Donor> donors);
    }
}
