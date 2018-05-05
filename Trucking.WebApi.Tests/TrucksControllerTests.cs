using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Trucking.Entities.Models;
using Trucking.Service;
using Trucking.WebApi.Controllers;

namespace Trucking.WebApi.Tests
{
    [TestClass]
    public class TrucksControllerTests
    {
        private Mock<ITruckService> mockService;
        private TrucksController controller;

        [TestInitialize]
        public void BeforeEach()
        {
            mockService = new Mock<ITruckService>();
            controller = new TrucksController(mockService.Object);
        }

        [TestMethod]
        public void Get_ShouldCall_GetAll_OfService()
        {
            //SetUp
            mockService.Setup(x => x.GetAll()).Returns(new List<Truck>());
            //Act
            controller.Get();
            //Verify
            mockService.Verify(x => x.GetAll(), Times.Once);
        }
    }
}
