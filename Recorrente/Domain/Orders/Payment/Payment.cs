namespace Recorrente.Domain.Orders
{
    public class Payment
    {
        public string Provider { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public int Installments { get; set; }
        public CreditCard CreditCard { get; set; }
        public RecurrentPayment RecurrentPayment { get; set; }
    }
}