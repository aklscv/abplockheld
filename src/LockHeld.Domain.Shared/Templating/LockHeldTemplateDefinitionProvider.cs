using LockHeld.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.TextTemplating;

namespace LockHeld.Templating
{
    public class LockHeldTemplateDefinitionProvider : TemplateDefinitionProvider
    {
        public override void Define(ITemplateDefinitionContext context)
        {
            context.Add(
                new TemplateDefinition(
                    "TestTemplate",
                    localizationResource: typeof(LockHeldResource)
                ).WithVirtualFilePath("/Templating/Emails/TestTemplate.tpl", true)
            );
        }
    }
}
