using System;
using System.Globalization;
 
namespace herança_polimorfismo.Entities
{
	class UsedProduct : Product
	{
		public String ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, string manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name
            + " (used) R$"
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufacture date: "
            + ManufactureDate
            + ")";
        }
    }
}

