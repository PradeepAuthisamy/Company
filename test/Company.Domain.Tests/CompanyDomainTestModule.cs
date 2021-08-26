using Company.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Company
{
    [DependsOn(
        typeof(CompanyEntityFrameworkCoreTestModule)
        )]
    public class CompanyDomainTestModule : AbpModule
    {

    }
}