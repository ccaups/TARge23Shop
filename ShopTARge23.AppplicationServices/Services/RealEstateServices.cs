using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Dto;
using ShopTARge23.Data;
using ShopTARge23.Core.Domain;
using ShopTARge23.Core.ServiceInterface;

namespace ShopTARge23.ApplicationServices.Services
{
    public class RealEstateServices : IRealEstatesServices
    {
        private readonly ShopTARge23Context _context;
        private readonly IFileServices _fileServices;

        public RealEstateServices
            (
            ShopTARge23Context context,
            IFileServices fileServices
            )
        {
            _context = context;
            _fileServices = fileServices;
        }
        public async Task<RealEstate> Create(RealEstateDto dto)
        {
            RealEstate realestate = new RealEstate();

            realestate.Id = Guid.NewGuid();
            realestate.Size = dto.Size;
            realestate.Location = dto.Location;
            realestate.RoomNumber = dto.RoomNumber;
            realestate.BuildingType = dto.BuildingType;
            realestate.CreatedAt = DateTime.Now;
            realestate.ModifiedAt = DateTime.Now;

            await _context.RealEstates.AddAsync(realestate);
            await _context.SaveChangesAsync();

            return realestate;
        }

        public async Task<RealEstate> DetailAsync(Guid id)
        {
            var result = await _context.RealEstates
                   .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<RealEstate> Update(RealEstateDto dto)
        {
            RealEstate domain = new();

            domain.Id = dto.Id;
            domain.Size = dto.Size;
            domain.Location = dto.Location;
            domain.RoomNumber = dto.RoomNumber;
            domain.BuildingType = dto.BuildingType;
            domain.CreatedAt = dto.CreatedAt;
            domain.ModifiedAt = DateTime.Now;

            _context.RealEstates.Update(domain);
            await _context.SaveChangesAsync();

            return domain;
        }

        public async Task<RealEstate> Delete(Guid id)
        {
            var realestate = await _context.RealEstates
                .FirstOrDefaultAsync(x => x.Id == id);

            _context.RealEstates.Remove(realestate);
            await _context.SaveChangesAsync();

            return realestate;
        }
    }
}
