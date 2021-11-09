using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IDiseaseRepository
    {
        public List<Disease> GetDisease();
        public bool CreateDisease(Disease disease);
        public bool UpdateDisease(Disease disease);
        public bool DeleteDisease(int id);
    }
}
