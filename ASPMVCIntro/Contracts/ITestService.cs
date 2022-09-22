using ASPMVCIntro.Models;

namespace ASPMVCIntro.Contracts
{
    public interface ITestService
    {
           string GetProduct(TestModel model);
    }
}
