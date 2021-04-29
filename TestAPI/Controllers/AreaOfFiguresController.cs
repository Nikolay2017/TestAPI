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
        /// <param name="sides">Cтороны</param>
        /// <returns></returns>
        [HttpGet]
        public double GetAreaCalculation([FromQuery] string type, [FromQuery] List<double> sides)
        {
            double area = _service.AreaCalculation(type, sides);
            return area;
        }
    }
}
