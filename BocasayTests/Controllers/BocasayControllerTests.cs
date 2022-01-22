using Bocasay.BAL;
using Bocasay.BAL.Handlers;
using Bocasay.Model.BocasayForm;
using BocasayTests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using Unity;
using static Bocasay.Delegate.Delegate;

namespace Bocasay.Controllers.Tests
{
    [TestClass()]
    public class BocasayControllerTests : BaseTest
    {
        private Mock<ServiceResolver> serviceResolver;

        [TestInitialize]
        public void Setup() 
        {
            this.serviceResolver = new Mock<ServiceResolver>();
        }

        [TestMethod()]
        public void StoredTestAsync()
        {
            // Arrange
            Container.RegisterType<IHandler, ManageDataHandler>(TypeLifetime.Transient);
            var handler = Container.Resolve<IHandler>();
            this.serviceResolver.Setup(x => x.Invoke(nameof(ManageDataHandler))).Returns(handler);

            var controller = new BocasayController(serviceResolver.Object);

            TestingForm param = new TestingForm {FirstName = "test1" , LastName = "test2" } ;

            var result = controller.Stored(JsonConvert.SerializeObject(param) as object) as OkObjectResult;
      
            Assert.AreEqual(200,result.StatusCode);
        }
    }
}