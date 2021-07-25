using System.Collections.Generic;

namespace EShopSolution.VM.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}