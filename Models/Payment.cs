namespace back_end_s5_l01.Models
{
    public class Payment
    {
        public DateTime PaymentPeriod { get; set; }
        public decimal Amount { get; set; }
        public bool IsAdvance { get; set; }
    }
}
