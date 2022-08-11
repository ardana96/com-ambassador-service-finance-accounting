using Com.Ambassador.Service.Finance.Accounting.Lib;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace Com.Ambassador.Service.Finance.Accounting.WebApi.Controllers.v1.RealizationVBWIthPO
{
    public class DetailitemunitReceiptNote
    {
        public decimal PriceTotal { get; set; }
        public Product_VB Product { get; set; }
    }
}