using sendmailsms.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace sendmailsms;

[DependsOn(
    typeof(sendmailsmsEntityFrameworkCoreTestModule)
    )]
public class sendmailsmsDomainTestModule : AbpModule
{

}
