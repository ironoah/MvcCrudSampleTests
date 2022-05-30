using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcCrudSample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCrudSample.Models;
using System.Diagnostics;
using System.Web.Mvc;

namespace MvcCrudSample.Controllers.Tests
{
    [TestClass()]
    public class MembersControllerTests
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\<localpath>\MvcCrudSample\App_Data");
        }

        [TestMethod()]
        public void MembersControllerTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void IndexTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void DetailsTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void CreateTest()
        {
            // arrange
            var ctrl = new MembersController();
            
            // act
            var result = ctrl.Create(new Member { name = "test", birth = new DateTime(2001,1,1), age=18 }) as ViewResult;

            // assert
            Assert.AreEqual(String.Empty, result.ViewName); // fail
        }

        [TestMethod()]
        public void CreateTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void EditTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void EditTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {
            //Assert.Fail();
        }
    }
}
