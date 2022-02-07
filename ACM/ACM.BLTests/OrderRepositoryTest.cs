﻿using ACM.BL;
using System;
using Xunit;

namespace ACM.Tests.BLTest
{
  public class OrderRepositoryTests
  {
    [Fact]
    public void RetrieveOrderDisplayTest()
    {
      var orderRepository = new OrderRepository();
      var expected = new Order(10)
      {
        OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, 
                                       new TimeSpan(7, 0, 0)),
      };

      var actual = orderRepository.Retrieve(10);

      Assert.Equal(expected.OrderDate, actual.OrderDate);
    }
  }
}

