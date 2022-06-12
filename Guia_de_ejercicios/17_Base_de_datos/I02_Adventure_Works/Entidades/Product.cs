using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Product
    {
        private int id;
        private string name;
        private string number;
        private bool makeFlag;
        private bool finishedGoodsFlag;
        private string color;
        private short safetyStockLevel;
        private short recorderPoint;
        private decimal standardCost;
        private decimal listPrice;
        private string size;
        private string sizeUnitMeasureCode;
        private string weightUniteMesuareCode;
        private decimal weight;
        private int daysToManufacture;
        private string productLine;
        private string classProd;
        private string style;
        private int subcategoryId;
        private int modelId;
        private DateTime sellStartDate;
        private DateTime sellEndDate;
        private DateTime discontinuedDate;
        private Guid rowguid;

        public Product(int id, string name, string number, bool makeFlag, bool finishedGoodsFlag, short safetyStockLevel, short recorderPoint, decimal standardCost, decimal listPrice, int daysToManufacture, DateTime sellStartDate,  Guid rowguid)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.makeFlag = makeFlag;
            this.finishedGoodsFlag = finishedGoodsFlag;
            this.safetyStockLevel = safetyStockLevel;
            this.recorderPoint = recorderPoint;
            this.standardCost = standardCost;
            this.listPrice = listPrice;
            this.daysToManufacture = daysToManufacture;
            this.sellStartDate = sellStartDate;
            this.rowguid = rowguid;
        }

        public Product(int id, string name, string number, bool makeFlag, bool finishedGoodsFlag, string color, short safetyStockLevel, short recorderPoint, decimal standardCost, decimal listPrice, string size, string sizeUnitMeasureCode, string weightUniteMesuareCode, decimal weight, int daysToManufacture, string productLine, string classProd, string style, int subcategoryId, int modelId, DateTime sellStartDate, DateTime sellEndDate, DateTime discontinuedDate, Guid rowguid)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.makeFlag = makeFlag;
            this.finishedGoodsFlag = finishedGoodsFlag;
            this.color = color;
            this.safetyStockLevel = safetyStockLevel;
            this.recorderPoint = recorderPoint;
            this.standardCost = standardCost;
            this.listPrice = listPrice;
            this.size = size;
            this.sizeUnitMeasureCode = sizeUnitMeasureCode;
            this.weightUniteMesuareCode = weightUniteMesuareCode;
            this.weight = weight;
            this.daysToManufacture = daysToManufacture;
            this.productLine = productLine;
            this.classProd = classProd;
            this.style = style;
            this.subcategoryId = subcategoryId;
            this.modelId = modelId;
            this.sellStartDate = sellStartDate;
            this.sellEndDate = sellEndDate;
            this.discontinuedDate = discontinuedDate;
            this.rowguid = rowguid;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public bool MakeFlag { get => makeFlag; set => makeFlag = value; }
        public bool FinishedGoodsFlag { get => finishedGoodsFlag; set => finishedGoodsFlag = value; }
        public string Color { get => color; set => color = value; }
        public short SafetyStockLevel { get => safetyStockLevel; set => safetyStockLevel = value; }
        public short RecorderPoint { get => recorderPoint; set => recorderPoint = value; }
        public decimal StandardCost { get => standardCost; set => standardCost = value; }
        public decimal ListPrice { get => listPrice; set => listPrice = value; }
        public string Size { get => size; set => size = value; }
        public string SizeUnitMeasureCode { get => sizeUnitMeasureCode; set => sizeUnitMeasureCode = value; }
        public string WeightUniteMesuareCode { get => weightUniteMesuareCode; set => weightUniteMesuareCode = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public int DaysToManufacture { get => daysToManufacture; set => daysToManufacture = value; }
        public string ProductLine { get => productLine; set => productLine = value; }
        public string ClassProd { get => classProd; set => classProd = value; }
        public string Style { get => style; set => style = value; }
        public int SubcategoryId { get => subcategoryId; set => subcategoryId = value; }
        public int ModelId { get => modelId; set => modelId = value; }
        public DateTime SellStartDate { get => sellStartDate; set => sellStartDate = value; }
        public DateTime SellEndDate { get => sellEndDate; set => sellEndDate = value; }
        public DateTime DiscontinuedDate { get => discontinuedDate; set => discontinuedDate = value; }
        public Guid Rowguid { get => rowguid; set => rowguid = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine($"ProductID: {this.Id} | Name: {this.Name} | Product Number: {this.Number}");
            sb.AppendLine($"Color: {this.Color} | Size: {this.Size} | Weight: {this.Weight}");
            sb.AppendLine($"ListPrice: {this.ListPrice} | StandardCost: {this.StandardCost} | DaysToManufacture: {this.DaysToManufacture}");
            sb.AppendLine($"SellStartDate: {this.SellStartDate} | SellEndDate: {this.SellEndDate} | RowGuid: {this.Rowguid}");
            sb.AppendLine("************************************************************************");

            return sb.ToString();
        }
    }
}
