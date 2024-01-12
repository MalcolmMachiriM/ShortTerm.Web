namespace ShortTerm.Web.Models
{
    public class SearchClientResultVM
    {
        public int ID { get; set; }

        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; } //this is a string because its for presentation purposes from javascript calls

        public string NationalID { get; set; }

        public double CurrentAge { get; set; }
    }
}
