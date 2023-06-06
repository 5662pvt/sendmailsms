using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.TextTemplating;
using Volo.Abp.TextTemplating.Scriban;

namespace sendmailsms.Emailling
{
    internal class EmailTemplateDefinitionProvider : TemplateDefinitionProvider
    {
        public override void Define(ITemplateDefinitionContext context)
        {
            context.Add(new TemplateDefinition(EmailTemplate.Layout, isLayout: true)
                .WithScribanEngine().WithVirtualFilePath("/Emailling/Templates/Layout.tpl", isInlineLocalized: true));

            context.Add(new TemplateDefinition(name: EmailTemplate.WelcomeEmail, layout: EmailTemplate.Layout)
                .WithVirtualFilePath("/Emailling/Templates/WelcomeEmail.tpl", isInlineLocalized: true).WithScribanEngine());

            context.Add(new TemplateDefinition(name: EmailTemplate.CreateOrderEmail, layout: EmailTemplate.Layout)
                .WithVirtualFilePath("/Emailling/Templates/CreateOrderEmail.tpl", isInlineLocalized: true).WithScribanEngine());
        }
    }
}
