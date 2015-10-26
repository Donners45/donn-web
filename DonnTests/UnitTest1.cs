using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DonnWeb.Models.Navigation;
using System.Collections.Generic;
using System.Linq;
using DonnAdapter.Adaptor;

namespace DonnTests
{
    [TestClass]
    public class UnitTest1
    {

        // Set up Rhino Mocks !!

        [TestMethod]
        public void WhenCreateNewNavigationItemsModel_ExpectNavItemsNotNull()
        {

            //StandardNavigationItemModel y = new StandardNavigationItemModel() { Action = "abc", Id = 4};
            //List<StandardNavigationItemModel> p = new List<StandardNavigationItemModel>();
            //p.Add(y);

            //NavigationItemsModel x = new NavigationItemsModel() { ItemsInNavigation = p };

            //Assert.AreEqual(4, x.ItemsInNavigation);
        }


        [TestMethod]
        public void WhenICallgetItemFromRepo_AndStaticResouceExitsts_ExpectItem1()
        {

            StaticNavigationAdaptor adap = new StaticNavigationAdaptor();
            var x = adap.GetItemById(1);
            Assert.AreEqual(1, x.Id);
        }

        [TestMethod]
        public void WhenICallgetItemFromRepo_AndStaticResouceExitsts_ExpectItem2()
        {
            StaticNavigationAdaptor adap = new StaticNavigationAdaptor();
            var x = adap.GetItemById(2);
            Assert.AreEqual(2, x.Id);
        }


        [TestMethod]
        public void WhenICallgetItemFromRepo_AndStaticResouceNotExists_ExpectNull()
        {

            StaticNavigationAdaptor adap = new StaticNavigationAdaptor();
            var x = adap.GetItemById(5);
            Assert.IsNull(x);
        }
    }
}
