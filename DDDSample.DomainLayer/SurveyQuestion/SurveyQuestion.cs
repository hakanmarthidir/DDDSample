using DDDSample.SharedKernel.BaseClasses;
using DDDSample.SharedKernel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.DomainLayer.SurveyQuestion
{
    public class SurveyQuestion : Entity<Guid>
    {
        public string SurveyQuestionText { get; set; }
        public List<DDDSample.DomainLayer.SurveyQuestionOption.SurveyQuestionOption> Options { get; set; }
        public SurveyChoiceType ChoiceType { get; set; }
        public Guid SurveyId { get; set; }
        [Required]
        public Survey.Survey Survey { get; set; }
    }
}
