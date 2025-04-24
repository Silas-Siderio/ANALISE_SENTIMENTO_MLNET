
using Microsoft.ML.Data;

namespace SentimentAnalysisMLNET.API.Models
{
    public class InputModel
    {
        [LoadColumn(0)]
        public string SentimentText { get; set; }
    }
}
