using Microsoft.AspNetCore.Mvc;


namespace ApiMathApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        Class207.Math clsMathService = new Class207.Math();

        [HttpGet("sum")]
        public int Get(int num1, int num2) => clsMathService.sum(num1, num2);

        [HttpGet("substruction")]
        public double Get(double num1, double num2) => clsMathService.substruction(num1, num2);

        [HttpGet("deploy")]
        public double Getdeploy(double num1, double num2) => clsMathService.deploy(num1, num2);

        [HttpGet("procentCount")]
        public double GetprocentCount(double num1, double num2) => clsMathService.procentCount(num1, num2);

        [HttpGet("deProcentCount")]
        public double GetdeProcentCount(double num1, double num2) => clsMathService.deProcentCount(num1, num2);

        [HttpGet("Остаток")]
        public int remainderDivisionCount2(int num1, int num2) => clsMathService.remainderDivisionCount2(num1, num2);

        [HttpGet("factorialCount")]
        public double GetfactorialCount(double num1) => clsMathService.factorialCount(num1);

        [HttpPost("arraySum")]
        public double arraySum(double[] array) => clsMathService.arraySum(array);

        [HttpPost("arrayCount")]
        public double arrayCount(double[] array) => clsMathService.arrayCount(array);
        [HttpPost("minNumber")]
        public double minNumber(double[] array) => clsMathService.maxNumber(array);
        [HttpPost("arraySort")]
        public double[] arraySort(double[] array) => clsMathService.arraySort(array);


    }
}
