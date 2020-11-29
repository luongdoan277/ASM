using System.Linq;

namespace ASM.Models
{
    public class EFStoreRepository : IStoreReponsitory
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
        public IQueryable<Size> Sizes => context.Sizes;
        public IQueryable<Category> Categories => context.Categories;

    }
}
