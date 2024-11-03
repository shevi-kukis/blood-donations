namespace blood_donations.Entities
{
    public enum Sex { Male, Female }

    public enum HealthFund { Leumit, Macabi, Mehuchdet, Clalit }

    public enum LevelOfUrgency { mostUrgent, Urgent, NotUrgent }
    public class Patient
    {
        public string FirstNamePatient { get; set; }
        public string LastNamePatient { get; set; }


        public string IdPatient { get; set; }

        public string Id { get; set; }
        public DateOnly BirthDate { get; set; }

        public Sex sex { get; set; }

        public string Origin { get; set; }

        public HealthFund healthFund { get; set; }

        public string AddressPatient { get; set; }

        public LevelOfUrgency levelOfUrgency { get; set; }

        public string bloodType { get; set; }

        public string IdEmployee { get; set; }


    }
}
