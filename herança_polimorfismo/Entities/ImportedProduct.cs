using System;
using System.Globalization;

namespace herança_polimorfismo.Entities
{
	class ImportedProduct : Product
	{
		public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + "(Customs fee: R$" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}

