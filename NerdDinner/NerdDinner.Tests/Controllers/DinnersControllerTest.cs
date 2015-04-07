using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdDinner.Controllers;
using NerdDinner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Data;




namespace NerdDinner.Tests.Controllers
{   
   [TestClass]
   public class DinnersControllerTest
    {
       
       [TestMethod]
       public void testIndex()
       {
           var controller = new DinnersController(new FakeDinnerRepository());
           var result = controller.Index() as  ViewResult;
           var data = result.ViewData.Model as IList<Dinner>;
           Assert.IsTrue(data.Count > 0);
       }
    }
  
}
