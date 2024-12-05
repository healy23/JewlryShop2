namespace JewlryShop2.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }

        public int CostumerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Jewelry> Basket { get; set; }
    }
}
