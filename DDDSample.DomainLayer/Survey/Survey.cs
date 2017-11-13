using DDDSample.SharedKernel.BaseClasses;
using DDDSample.SharedKernel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.DomainLayer.Survey
{
    public class Survey : Entity<Guid>
    {
        [Required]
        [StringLength(50)]
        public string SurveyName { get; set; }
        public DateTime SurveyStartingDate { get; set; }
        public DateTime SurveyEndingDate { get; set; }
        public List<SurveyQuestion.SurveyQuestion> SurveyQuestions { get; set; }
        public Departman SurveyDepartman { get; set; }
    }
}
