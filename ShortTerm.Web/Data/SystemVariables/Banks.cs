namespace ShortTerm.Web.Data
{
    public class Banks : BaseEntity
    {
        public string Code { get; set; }
        public string BankName { get; set; }
        public int NumberOfBranches { get; set; }
        public int accountNumberLength { get; set; }
    }
}