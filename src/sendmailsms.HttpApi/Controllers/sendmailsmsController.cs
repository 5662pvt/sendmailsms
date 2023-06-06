using sendmailsms.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace sendmailsms.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class sendmailsmsController : AbpControllerBase
{
    protected sendmailsmsController()
    {
        LocalizationResource = typeof(sendmailsmsResource);
    }
}
