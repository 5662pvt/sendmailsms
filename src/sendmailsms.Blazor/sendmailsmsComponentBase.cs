using sendmailsms.Localization;
using Volo.Abp.AspNetCore.Components;

namespace sendmailsms.Blazor;

public abstract class sendmailsmsComponentBase : AbpComponentBase
{
    protected sendmailsmsComponentBase()
    {
        LocalizationResource = typeof(sendmailsmsResource);
    }
}
