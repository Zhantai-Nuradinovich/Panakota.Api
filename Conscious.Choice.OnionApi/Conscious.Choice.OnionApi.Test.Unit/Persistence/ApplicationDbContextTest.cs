﻿using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Conscious.Choice.OnionApi.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertDataIntoDatabasee()
        {

            //using var context = new ApplicationDbContext();
            //var customer = new Customer();
            //context.Customers.Add(customer);
            //Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
