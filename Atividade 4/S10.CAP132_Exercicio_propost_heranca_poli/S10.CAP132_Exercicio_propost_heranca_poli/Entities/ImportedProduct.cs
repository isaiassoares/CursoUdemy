using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace S10.CAP132_Exercicio_propost_heranca_poli.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name,price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
