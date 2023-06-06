using System;
using System.Collections.Generic;
using System.Text;
using sendmailsms.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Localization;

namespace sendmailsms;

/* Inherit your application services from this class.
 */
public abstract class sendmailsmsAppService : ApplicationService
{
    protected sendmailsmsAppService()
    {
        LocalizationResource = typeof(sendmailsmsResource);
        ObjectMapperContext = typeof(sendmailsmsApplicationModule);

    }
}
