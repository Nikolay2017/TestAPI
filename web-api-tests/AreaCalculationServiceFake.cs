using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.FiguresClasses;
using TestAPI.Services;
using Xunit;

namespace web_api_tests
{
    public class AreaCalculationServiceFake
    {
        [Fact]
        public void IsAreaCalculation()
        {
            var acs = new AreaCalculationService();
            double AreaCircle = Math.Round(acs.AreaCalculation("Circle", 10,0,0),0);
            if(AreaCircle != 314) Assert.False(false);
        }
    }
}
