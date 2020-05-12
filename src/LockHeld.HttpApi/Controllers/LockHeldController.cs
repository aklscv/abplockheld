using LockHeld.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LockHeld.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LockHeldController : AbpController
    {
        protected LockHeldController()
        {
            LocalizationResource = typeof(LockHeldResource);
        }
    }
}