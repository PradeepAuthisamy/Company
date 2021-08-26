using Volo.Abp.Modularity;

namespace Company
{
    [DependsOn(
        typeof(CompanyApplicationModule),
        typeof(CompanyDomainTestModule)
        )]
    public class CompanyApplicationTestModule : AbpModule
    {

    }
}