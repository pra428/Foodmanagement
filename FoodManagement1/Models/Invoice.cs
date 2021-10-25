using ProductManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductManagement.Models
{
    public class Invoice : Base
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

        public string DistributorName { get; set; }

        public string DistributorAddress { get; set; }

        public int DistributorPanNo { get; set; }

        public string TransactionDate { get; set; }

        public string IssuedDate { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal TaxablePrice { get; set; }

        public decimal VatAmount { get; set; }

        public decimal TotalAmount { get; set; }


    }
}