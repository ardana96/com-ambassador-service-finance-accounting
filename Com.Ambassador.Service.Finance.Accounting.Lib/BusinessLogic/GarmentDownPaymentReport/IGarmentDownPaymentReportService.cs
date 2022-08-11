using Com.Ambassador.Service.Finance.Accounting.Lib.Enums.Expedition;
using System;
using System.Collections.Generic;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.GarmentDownPaymentReport
{
    public interface IGarmentDownPaymentReportService
    {
        List<GarmentDownPaymentReportDto> GetReport(SupplierType supplierType, DateTimeOffset date);
    }
}
