namespace demo2.Models
{
    public class Order
    {
        //public int Id { get; set; }
        //public int ProductId { get; set; }
        //public int CustomerId { get; set; }
        //public DateTime OrderDate { get; set; }
        //public string Status { get; set; }

        public int Id { get; set; }
        public int ProductId { get; set; } // Foreign key for Product
        public int CustomerId { get; set; } // Foreign key for Customer
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
