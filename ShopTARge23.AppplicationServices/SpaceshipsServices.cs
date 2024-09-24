using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Domain;
using ShopTARge23.Data;
using ShopTARge23.Core.Servicesinerface;


namespace ShopTARge23.ApplicationServices.Services
{
    public class SpaceshipsServices : ISpaceshipsServices
    {
        private readonly ShopTARge23Context _context;

        public SpaceshipsServices
            (ShopTARge23Context context) 
        { 
        _context = context;
        }

        public async Task<Spaceship> DetailAsync(Guid Id)
        {
            var result = await _context.Spaceships
                .FirstOrDefaultAsync(x => x.Id == Id);
            return result;
        }
    }

}
