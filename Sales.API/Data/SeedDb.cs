
namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Shared.Entities.Country { Name = "Colombia" });
                _context.Countries.Add(new Shared.Entities.Country { Name = "Perú" });
                _context.Countries.Add(new Shared.Entities.Country { Name = "Mexico" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
