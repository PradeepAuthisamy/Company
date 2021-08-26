using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Company.Pages
{
    public class Index_Tests : CompanyWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
