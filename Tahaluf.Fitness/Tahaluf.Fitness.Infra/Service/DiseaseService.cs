using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class DiseaseService:IDiseaseService
    {
        private readonly IDiseaseRepository diseaseRepository;

        public DiseaseService(IDiseaseRepository diseaseRepository)
        {
            this.diseaseRepository = diseaseRepository;
        }
        public List<Disease> GetDisease()
        {
            return diseaseRepository.GetDisease();
        }
        public bool CreateDisease(Disease disease)
        {
            return diseaseRepository.CreateDisease(disease);
        }
        public List<Disease> GetDiseaseByUserID(int id)
        {
            return diseaseRepository.GetDiseaseByUserID(id);
        }

        public bool UpdateDisease(Disease disease,int id)
        {
            return diseaseRepository.UpdateDisease(disease,id);
        }
        public bool DeleteDisease(int id)
        {
            return diseaseRepository.DeleteDisease(id);
        }
    }
}
