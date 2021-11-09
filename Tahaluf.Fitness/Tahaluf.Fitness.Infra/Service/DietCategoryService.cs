using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class DietCategoryService: IDietCategoryService
    {
        private readonly IDietCategoryRepository dietCategoryRepository;

        public DietCategoryService(IDietCategoryRepository dietCategoryRepository)
        {
            this.dietCategoryRepository = dietCategoryRepository;
        }


        public List<DietCategory> GetDietCategory()
        {
            return dietCategoryRepository.GetDietCategory();
        }
        public bool CreateDietCategory(DietCategory dietCategory)
        {
            return dietCategoryRepository.CreateDietCategory(dietCategory);
        }
        public bool UpdateDietCategory(DietCategory dietCategory)
        {
            return dietCategoryRepository.UpdateDietCategory(dietCategory);
        }
        public bool DeleteDietCategory(int id)
        {
            return dietCategoryRepository.DeleteDietCategory(id);
        }
    }
}
