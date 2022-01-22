using Unity;

namespace BocasayTests
{
    public abstract class BaseTest
    {
        protected UnityContainer Container;
        protected BaseTest()
        {
            Container = new UnityContainer().AddExtension(new Diagnostic()) as UnityContainer;
        }       
    }
}
