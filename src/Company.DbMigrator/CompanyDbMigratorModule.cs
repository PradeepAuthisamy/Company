using Company.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Company.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CompanyEntityFrameworkCoreModule),
        typeof(CompanyApplicationContractsModule)
        )]
    public class CompanyDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
