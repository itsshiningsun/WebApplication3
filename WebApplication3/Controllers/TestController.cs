using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;
        private readonly IMathService _mathService;


        public TestController(ILogger<TestController> logger, IMathService mathService)
        {
            _logger = logger;
            _mathService = mathService;
        }
        public string Get()
        {
            try
            {
                decimal result = _mathService.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                _logger.LogError(ex, "Test Log: An exception occured while dividing two numbers");
            }
            return null;

        }
    }
}