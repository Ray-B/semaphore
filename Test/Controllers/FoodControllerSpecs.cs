using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Signal.API.Controllers.Foods;
using Signal.API.DTOs.Food;
using System.Collections.Generic;

namespace Signal.API.Test.Controllers
{
    public class FoodControllerSpecs
    {
        FoodsController controller;

        public FoodControllerSpecs()
        {
            this.controller = new FoodsController();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void it_should_return_Ok()
        {
            var result = controller.Get();
     
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
        }

        [Test]
        public void it_should_return_a_list_of_foods()
        {
            var result = controller.Get().Result as OkObjectResult;

            Assert.IsInstanceOf<List<FoodDto>>(result.Value);
        }

    }
}
