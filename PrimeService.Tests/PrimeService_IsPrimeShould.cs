using System;
using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services 
{
  public class PrimeService_IsPrimeShould
  {
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
      var primeService = new PrimeService();
      var result = primeService.IsPrime(1);
      Assert.False(result, "1 should not be prime");
    }
  }
}
