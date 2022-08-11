using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Services.CacheService
{
    public interface ICacheService
    {
        string GetString(string key);
    }
}
