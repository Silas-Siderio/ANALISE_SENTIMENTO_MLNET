
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using SentimentAnalysisMLNET.API.Models;

namespace SentimentAnalysisMLNET.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SentimentController : ControllerBase
    {
        private readonly PredictionEngine<InputModel, OutputModel> _predictionEngine;

        public SentimentController(PredictionEngine<InputModel, OutputModel> predictionEngine)
        {
            _predictionEngine = predictionEngine;
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputModel input)
        {
            var result = _predictionEngine.Predict(input);
            return Ok(result);
        }
    }
}
