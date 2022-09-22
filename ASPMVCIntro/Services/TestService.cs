using ASPMVCIntro.Contracts;
using ASPMVCIntro.Models;

namespace ASPMVCIntro.Services
{
    public class TestService : ITestService
    {
        public string GetProduct(TestModel model)
        {
            return model.Product;
        }
    }
}
