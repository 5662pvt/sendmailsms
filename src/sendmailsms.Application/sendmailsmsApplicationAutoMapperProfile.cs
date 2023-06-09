using AutoMapper;
using sendmailsms.Blazor.Pages;
using Volo.Abp.SettingManagement;

namespace sendmailsms;

public class sendmailsmsApplicationAutoMapperProfile : Profile
{
    public sendmailsmsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<EmailSettingsDto, Send.UpdateEmailSettingsViewModel>();

        CreateMap<Send.SendTestEmailViewModel, SendTestEmailInput>();

        CreateMap<Send.UpdateEmailSettingsViewModel, UpdateEmailSettingsDto>();

        CreateMap<EmailSettingsDto, Mail.UpdateEmailSettingsViewModel>();

        CreateMap<Mail.SendTestEmailViewModel, SendTestEmailInput>();

        CreateMap<Mail.UpdateEmailSettingsViewModel, UpdateEmailSettingsDto>();
    }
}
