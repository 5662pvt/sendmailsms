using sendmailsms.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace sendmailsms.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(sendmailsmsEntityFrameworkCoreModule),
    typeof(sendmailsmsApplicationContractsModule)
    )]
public class sendmailsmsDbMigratorModule : AbpModule
{

}
