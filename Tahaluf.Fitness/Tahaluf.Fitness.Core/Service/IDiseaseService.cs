using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IDiseaseService
    {
        public List<Disease> GetDisease();
        public bool CreateDisease(Disease disease);
        public bool UpdateDisease(Disease disease, int id );
        public bool DeleteDisease(int id);
        public List<Disease> GetDiseaseByUserID(int id);

    }
}
