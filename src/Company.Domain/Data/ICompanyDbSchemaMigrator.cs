using System.Threading.Tasks;

namespace Company.Data
{
    public interface ICompanyDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
