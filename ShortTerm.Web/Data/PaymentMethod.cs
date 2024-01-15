namespace ShortTerm.Web.Data
{
    public class PaymentMethod : BaseEntity
    {
        public string Method { get; set; }
        public string Code { get; set; }
        public bool BankDetailsRequired { get; set; }
        public bool MobileNumRequired { get; set; }
    }
}
