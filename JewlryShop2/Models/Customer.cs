namespace JewlryShop2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string CustomerGmail { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
