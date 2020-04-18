using System;
using Xunit;

namespace App.Tests
{
    public class SumServiceTest
    {
        [Fact]
        public void ShouldReturn5()
        {
            Assert.Equal(5, SumService.Sum(2, 3));
        }
    }
}
