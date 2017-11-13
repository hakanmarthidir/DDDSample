using DDDSample.SharedKernel.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.DomainLayer.SurveyQuestionOption
{
    public class SurveyQuestionOption : Entity<Guid>
    {
        public string AnswerText { get; set; }
        [Required]
        public DDDSample.DomainLayer.SurveyQuestion.SurveyQuestion SurveyQuestion { get; set; }

    }
}
