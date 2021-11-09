using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IDietCategoryRepository
    {
        public List<DietCategory> GetDietCategory();
        public bool CreateDietCategory(DietCategory dietCategory);
        public bool UpdateDietCategory(DietCategory dietCategory);
        public bool DeleteDietCategory(int id);
    }
}
