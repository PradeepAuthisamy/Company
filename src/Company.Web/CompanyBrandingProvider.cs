using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Company.Web
{
    [Dependency(ReplaceServices = true)]
    public class CompanyBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Company";
    }
}
