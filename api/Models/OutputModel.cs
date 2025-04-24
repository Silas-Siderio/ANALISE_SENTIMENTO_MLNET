
using Microsoft.ML.Data;

namespace SentimentAnalysisMLNET.API.Models
{
    public class OutputModel : InputModel
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
