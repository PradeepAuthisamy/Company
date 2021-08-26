using System;
using System.Collections.Generic;
using System.Text;
using Company.Localization;
using Volo.Abp.Application.Services;

namespace Company
{
    /* Inherit your application services from this class.
     */
    public abstract class CompanyAppService : ApplicationService
    {
        protected CompanyAppService()
        {
            LocalizationResource = typeof(CompanyResource);
        }
    }
}
