using DDDSample.ApplicationLayer.Services;
using DDDSample.DomainLayer.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDSample.PresentationLayer.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            this._surveyService = surveyService;
        }

        // GET: Survey
        public ActionResult Index()
        {
            var insertItem = new Survey();
            insertItem.SurveyDepartman = SharedKernel.Enums.Departman.RD;
            insertItem.SurveyName = "Deneme";
            insertItem.Id = Guid.NewGuid();
            insertItem.SurveyStartingDate = DateTime.UtcNow;
            insertItem.SurveyEndingDate = DateTime.UtcNow;
            insertItem.Status = SharedKernel.Enums.Status.Active;
            _surveyService.AddSurvey(insertItem);
            var model = _surveyService.GetActiveSurveyList();
            return View(model);
        }
    }
}