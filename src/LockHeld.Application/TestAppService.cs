using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.TextTemplating;

namespace LockHeld
{
    public class TestAppService : LockHeldAppService
    {
        public TestAppService(ITemplateRenderer templateRenderer)
        {
            TemplateRenderer = templateRenderer;
        }

        private ITemplateRenderer TemplateRenderer { get; }

        public async Task TestMethod()
        {
            await TemplateRenderer.RenderAsync("TestTemplate");

            return;
        }
    }
}
