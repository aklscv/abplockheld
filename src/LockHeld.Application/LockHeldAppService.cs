using System;
using System.Collections.Generic;
using System.Text;
using LockHeld.Localization;
using Volo.Abp.Application.Services;

namespace LockHeld
{
    /* Inherit your application services from this class.
     */
    public abstract class LockHeldAppService : ApplicationService
    {
        protected LockHeldAppService()
        {
            LocalizationResource = typeof(LockHeldResource);
        }
    }
}
