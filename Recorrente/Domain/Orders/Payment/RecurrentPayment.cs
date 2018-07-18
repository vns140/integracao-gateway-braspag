namespace Recorrente.Domain.Orders
{
    public class RecurrentPayment
    {
        public string EndDate { get; set; }
        public string Interval { get; set; }
        public bool AuthorizeNow { get; set; }
    }
}