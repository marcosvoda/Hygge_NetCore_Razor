using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Sideas.Hygge.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sideas.Hygge.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Sideas.Hygge.Web.Pages.HyggePage
     */
    public abstract class HyggePage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<HyggeResource> L { get; set; }
    }
}
