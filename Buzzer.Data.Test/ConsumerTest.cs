using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Buzzer.Entity;
using System.Diagnostics;
using System.Linq;

namespace Buzzer.Data.Test
{
    [TestClass]
    public class ConsumerTest
    {
         private IRepository _repository;

        [TestInitialize]
        public void Initialize()
         {
            _repository = new BuzzerRepository();
         }

        [TestMethod]
        public void Query_AllCustomers_NoException()
        {
            var list = _repository.All<Customer>();

            foreach (var item in list)
            {
                Trace.TraceInformation("Company Name : {0}", item.CompanyName);
                
            }
        }

    }

    


}
