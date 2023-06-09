using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sendmailsms.Localization;
using sendmailsms.MultiTenancy;
using Volo.Abp.Account.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace sendmailsms.Blazor.Menus;

public class sendmailsmsMenuContributor : IMenuContributor
{
    private readonly IConfiguration _configuration;

    public sendmailsmsMenuContributor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
        else if (context.Menu.Name == StandardMenus.User)
        {
            await ConfigureUserMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<sendmailsmsResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                sendmailsmsMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home"
            )
        );

        context.Menu.AddItem(
           new ApplicationMenuItem(
               "BooksStore",
               l["Menu:mail"],
               icon: "fa fa-book"
           ).AddItem(
               new ApplicationMenuItem(
                   "BooksStore.Books",
                   l["Menu:UpdateSetting"],
                   url: "/update"
               )
           ).AddItem(
               new ApplicationMenuItem(
                   "BooksStore.Books",
                   l["Menu:SenndMail"],
                   url: "/sendmail"
               )
           )
       );

        var administration = context.Menu.GetAdministration();

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }

    private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
    {
        var accountStringLocalizer = context.GetLocalizer<AccountResource>();

        var authServerUrl = _configuration["AuthServer:Authority"] ?? "";

        context.Menu.AddItem(new ApplicationMenuItem(
            "Account.Manage",
            accountStringLocalizer["MyAccount"],
            $"{authServerUrl.EnsureEndsWith('/')}Account/Manage?returnUrl={_configuration["App:SelfUrl"]}",
            icon: "fa fa-cog",
            order: 1000,
            null).RequireAuthenticated());

        return Task.CompletedTask;
    }
}
