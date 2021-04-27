using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.FiguresClasses;
using TestAPI.Services;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaOfFiguresController : ControllerBase
    {
        private readonly ILogger<AreaOfFiguresController> _logger;
        private readonly AreaCalculationService _service;
        public AreaOfFiguresController(ILogger<AreaOfFiguresController> logger, AreaCalculationService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <param name="type">Тип фигуры</param>
        /// <param name="side1">Значение стороны 1 или радиус</param>
        /// <param name="side2">Значение стороны 2</param>
        /// <param name="side3">Значение стороны 3</param>
        /// <returns></returns>
        [HttpGet]
        public double GetAreaCalculation(string type,double side1,double side2, double side3)
        {
            double area = _service.AreaCalculation(type,side1,side2,side3);
            return area;
        }
    }
}
