using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Sideas.Hygge.Web
{
    [Dependency(ReplaceServices = true)]
    public class HyggeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Hygge";
    }
}
