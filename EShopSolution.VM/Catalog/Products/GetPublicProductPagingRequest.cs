using EShopSolution.VM.Common;

namespace EShopSolution.VM.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}