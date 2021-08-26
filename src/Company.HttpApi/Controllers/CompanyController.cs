using Company.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Company.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CompanyController : AbpController
    {
        protected CompanyController()
        {
            LocalizationResource = typeof(CompanyResource);
        }
    }
}