using DDDSample.DomainLayer.Survey;
using DDDSample.DomainLayer.SurveyQuestion;
using DDDSample.DomainLayer.SurveyQuestionOption;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Context
{    
    public class SurveyContext : BaseContext<SurveyContext>
    {
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyQuestionOption> SurveyQuestionOptions { get; set; }
    }
}
