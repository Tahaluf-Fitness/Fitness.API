using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.Infra.Service
{
    public class BestFoodService:IBestFoodService
    {
        private readonly IBestFoodRepository bestFoodRepository;

        public BestFoodService(IBestFoodRepository bestFoodRepository)
        {
            this.bestFoodRepository = bestFoodRepository;
        }

        public List<BestFood> GetBestFood()
        {
            return bestFoodRepository.GetBestFood();
        }
        public bool CreateBestFood(BestFood bestFood)
        {
            return bestFoodRepository.CreateBestFood(bestFood);
        }
        public bool UpdateBestFood(BestFood bestFood)
        {
            return bestFoodRepository.UpdateBestFood(bestFood);
        }
        public bool DeleteBestFood(int id)
        {
            return bestFoodRepository.DeleteBestFood(id);
        }
    }
}
