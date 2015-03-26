namespace Entities
{
    public class Manager : Employer
    {
        public Employer Deputy { get; set; }

        public Employer Secretary { get; set; }

        public string Phone { get; set; }

        public bool OutOfOffice { get; set; }
    }
}
