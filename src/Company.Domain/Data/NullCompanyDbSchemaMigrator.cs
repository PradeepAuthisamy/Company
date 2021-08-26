using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Company.Data
{
    /* This is used if database provider does't define
     * ICompanyDbSchemaMigrator implementation.
     */
    public class NullCompanyDbSchemaMigrator : ICompanyDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}