namespace blood_donations.Entities
{
    public class CompatibilityCheck
    {
        public string Id { get; set; }

        public string IdPatient { get; set; }

        public int NumNeedDose { get; set; }

        public string IdBloodeDose { get; set; }

        public DateOnly DateCheck { get; set; }

    }
}
