using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace sendmailsms.Data;

/* This is used if database provider does't define
 * IsendmailsmsDbSchemaMigrator implementation.
 */
public class NullsendmailsmsDbSchemaMigrator : IsendmailsmsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
