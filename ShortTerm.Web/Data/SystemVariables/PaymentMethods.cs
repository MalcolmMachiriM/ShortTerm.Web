namespace ShortTerm.Web.Data
{
    public class PaymentMethods : BaseEntity
    {
        public string Method { get; set; }
        public string Code { get; set; }
        public string BankDetailsRequired { get; set; }
        public string MobileNumRequired { get; set; }
    }
}