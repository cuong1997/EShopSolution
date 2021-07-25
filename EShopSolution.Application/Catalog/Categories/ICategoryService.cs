using EShopSolution.VM.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}