using DDDSample.DomainLayer.Survey;
using DDDSample.InfrastructureLayer.Context;
using DDDSample.InfrastructureLayer.Repositories;
using DDDSample.InfrastructureLayer.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.ApplicationLayer.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly IGenericRepository<Survey, Guid> _surveyRepository;

        private readonly IUnitOfWork<SurveyContext> _unitOfWork;
        public SurveyService(IUnitOfWork<SurveyContext> unitOfWork, IGenericRepository<Survey, Guid> surveyRepository)
        {
            this._unitOfWork = unitOfWork;
            this._surveyRepository = surveyRepository;
        }


        public void AddSurvey(Survey survey)
        {
            this._surveyRepository.Insert(survey);
            _unitOfWork.Save();
        }

        public List<Survey> GetActiveSurveyList()
        {
            return this._surveyRepository.GetAll(x => x.Status == SharedKernel.Enums.Status.Active).ToList();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();

        }
    }
}
