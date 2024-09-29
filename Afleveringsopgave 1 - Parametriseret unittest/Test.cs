using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Afleveringsopgave_1___Parametriseret_unittest
{
    public class Test()
    {
        [Theory]
        [InlineData(2, 2.5, 0)]
        [InlineData(4, 10, 50)]
        [InlineData(5, 9, 75)]
        [InlineData(10, 10, 100)]

        public void BeregnTransportPris(double afstand, double vægt, int pris)
        {
            //Arrange
            TransportPris sut = new TransportPris();

            //Act 
            int beregnetPris = sut.BeregnTransportpris(afstand, vægt);

            //Assert
            Assert.Equal(beregnetPris, pris);
        }   
    }
}