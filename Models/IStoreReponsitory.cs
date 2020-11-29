using System.Linq;


namespace ASM.Models
{
    public interface IStoreReponsitory
    {
        IQueryable<Product> Products { get; }
        IQueryable<Size> Sizes { get; }
        IQueryable<Category> Categories { get; }
    }
}
