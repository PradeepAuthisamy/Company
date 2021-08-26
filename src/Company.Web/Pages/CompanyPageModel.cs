using Company.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Company.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CompanyPageModel : AbpPageModel
    {
        protected CompanyPageModel()
        {
            LocalizationResourceType = typeof(CompanyResource);
        }
    }
}