using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    class OpenedClosedPrinciple
    {
        public string ReportType { get; set; }
        public void GenerateReport()
        {
            if(ReportType == "StockInfo")
            {
                // Stock Information Report Generations
            }
            if (ReportType == "ProductInfo")
            {
                // Product Information Report Generations
            }
            if (ReportType == "SkuInfo")
            {
                // SkuInfo Information Report Generations
            }
        }

    }

    public class ReportGenerator
    {
        public virtual void GenerateReport()
        {
            //takes Employee class and based on the properties it will function.
        }
    }

    public class StockInformationReport : ReportGenerator
    {
        public override void GenerateReport()
        {
           // Generate Product Information Report
        }
    }

    public class ProductInformationReport : ReportGenerator
    {
        public override void GenerateReport()
        {
            // Generate Product Information Report
        }
    }
}
