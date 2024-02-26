namespace ShortTerm.Web.Data
{
    public class PremiumPayment : BaseEntity
    {
        public Policy? Policy { get; set; }
        public int PolicyId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }
        public Banks? Bank { get; set; }
        public double Amount { get; set; }
    }
}
