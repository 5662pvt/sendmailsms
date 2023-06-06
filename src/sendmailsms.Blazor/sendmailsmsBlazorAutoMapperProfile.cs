using AutoMapper;
using sendmailsms.Blazor.Pages;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Blazor.Pages.SettingManagement.EmailSettingGroup;

namespace sendmailsms.Blazor;

public class sendmailsmsBlazorAutoMapperProfile : Profile
{
    public sendmailsmsBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<EmailSettingsDto, Send.UpdateEmailSettingsViewModel>();

        CreateMap<Send.SendTestEmailViewModel, SendTestEmailInput>();

        CreateMap<Send.UpdateEmailSettingsViewModel, UpdateEmailSettingsDto>();
    }
}
