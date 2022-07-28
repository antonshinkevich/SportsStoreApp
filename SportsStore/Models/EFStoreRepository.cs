namespace SportsStore.Models;

class EFStoreRepository : IStoreRepository
{
    private readonly StoreDbContext _context;

    public EFStoreRepository(StoreDbContext ctx)
    {
        _context = ctx;
    }

    public IQueryable<Product> Products => _context.Products;
}
