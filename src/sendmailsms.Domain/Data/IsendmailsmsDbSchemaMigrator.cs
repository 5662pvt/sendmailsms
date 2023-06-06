using System.Threading.Tasks;

namespace sendmailsms.Data;

public interface IsendmailsmsDbSchemaMigrator
{
    Task MigrateAsync();
}
