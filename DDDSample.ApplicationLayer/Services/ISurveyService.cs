using DDDSample.DomainLayer.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.ApplicationLayer.Services
{
    public interface ISurveyService
    {
        List<Survey> GetActiveSurveyList();
        void AddSurvey(Survey survey);
    }
}
