using Volo.Abp.Modularity;

namespace sendmailsms;

[DependsOn(
    typeof(sendmailsmsApplicationModule),
    typeof(sendmailsmsDomainTestModule)
    )]
public class sendmailsmsApplicationTestModule : AbpModule
{

}
