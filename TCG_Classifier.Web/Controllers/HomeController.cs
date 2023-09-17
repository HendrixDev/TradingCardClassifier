using Microsoft.AspNetCore.Mvc;

namespace TCG_Classifier.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            byte[] imageBytes;

            using (var memStream = new MemoryStream())
            {
                file.CopyTo(memStream);
                imageBytes = memStream.ToArray();
            }

            MLModel1.ModelInput inputModel = new()
            {
                ImageSource = imageBytes
            };

            // Make a single prediction on the sample data and print results.
            var predictionResult = MLModel1.Predict(inputModel);

            ViewBag.PredictionResult = predictionResult.PredictedLabel;
            ViewBag.Base64Image = Convert.ToBase64String(imageBytes);

            return View();
        }
    }
}