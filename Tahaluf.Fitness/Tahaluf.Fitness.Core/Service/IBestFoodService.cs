using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IBestFoodService
    {
        public List<BestFood> GetBestFood();
        public bool CreateBestFood(BestFood bestFood);
        public bool UpdateBestFood(BestFood bestFood);
        public bool DeleteBestFood(int id);
    }
}
