using Sideas.Hygge.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sideas.Hygge.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class HyggePageModel : AbpPageModel
    {
        protected HyggePageModel()
        {
            LocalizationResourceType = typeof(HyggeResource);
        }
    }
}