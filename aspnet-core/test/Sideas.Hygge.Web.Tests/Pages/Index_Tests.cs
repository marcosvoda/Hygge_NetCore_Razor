using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Sideas.Hygge.Pages
{
    public class Index_Tests : HyggeWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
