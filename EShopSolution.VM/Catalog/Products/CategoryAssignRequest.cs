using EShopSolution.VM.Common;
using System.Collections.Generic;

namespace EShopSolution.VM.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}