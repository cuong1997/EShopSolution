using EShopSolution.VM.System.Languages;
using EShopSolution.VM.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}