using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace sendmailsms;

[Dependency(ReplaceServices = true)]
public class sendmailsmsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "sendmailsms";
}
