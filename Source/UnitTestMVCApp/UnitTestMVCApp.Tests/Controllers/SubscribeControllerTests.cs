using System;
using System.Web.Mvc;
using UnitTestMVCApp.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using UnitTestMVCApp.Models;

namespace UnitTestMVCApp.Tests.Controllers
{
    [TestClass]
    public class SubscribeControllerTests
    {

        [TestMethod]
        public void DisplaySubcriberForm() {
            //Arrange
            SubscribeController controller = new SubscribeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void DisplayASubcriber()
        {
            //Arrange
            SubscribeController controller = new SubscribeController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }





        [TestMethod]
        public void SubscriberValidates()
        {
            // ARRANGE
            var model = GetSubscriber();
            var context = new ValidationContext(model, null, null);
            var result = new List<ValidationResult>();

            // ACT
            var valid = Validator.TryValidateObject(model, context, result, true);

            //ASSERT
            Assert.IsTrue(valid);

        }


        [TestMethod]
        public void NameIsRequired()
        {
            // Arrange
            var model = GetSubscriber();
            model.Name = null;
            var context = new ValidationContext(model, null, null);

            var result = new List<ValidationResult>();

            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);
            


            //Assert
            Assert.IsFalse(valid);
            
     

        }

        [TestMethod]
        public void EmailIsRequired()
        {
            // Arrange
            var model = GetSubscriber();
            model.Email = null;
            var context = new ValidationContext(model, null, null);

            var result = new List<ValidationResult>();

            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);



            //Assert
            Assert.IsFalse(valid);


        }


        [TestMethod]
        public void NameIsLessThan35()
        {
            // Arrange
            var model = GetSubscriber();
            model.Name = new String('a',36);

            var context = new ValidationContext(model, null, null);

            var result = new List<ValidationResult>();

            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);



            //Assert
            Assert.IsFalse(valid);
        }



        [TestMethod]
        public void EmailIsValid()
        {
            // Arrange
            var model = GetSubscriber();
            model.Email = "testbad-addres";

            var context = new ValidationContext(model, null, null);

            var result = new List<ValidationResult>();

            // Act
            var valid = Validator.TryValidateObject(model, context, result, true);



            //Assert
            Assert.IsFalse(valid);

        }

        [TestMethod]
        public void SubscriberOver18()
        {

        }



        public Subscriber GetSubscriber() {

            // Arrange
            var model = new Subscriber()
            {
                Name = new string('a', 35),
                Email = "test@test.com",
                Birthday = new DateTime(1977, 01, 01)
            };
            return model;

        }






    }
}
