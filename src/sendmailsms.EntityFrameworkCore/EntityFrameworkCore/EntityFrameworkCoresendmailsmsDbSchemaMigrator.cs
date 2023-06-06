using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sendmailsms.Data;
using Volo.Abp.DependencyInjection;

namespace sendmailsms.EntityFrameworkCore;

public class EntityFrameworkCoresendmailsmsDbSchemaMigrator
    : IsendmailsmsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoresendmailsmsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the sendmailsmsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<sendmailsmsDbContext>()
            .Database
            .MigrateAsync();
    }
}
