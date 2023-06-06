using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace sendmailsms.Blazor;

[Dependency(ReplaceServices = true)]
public class sendmailsmsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "sendmailsms";
}
