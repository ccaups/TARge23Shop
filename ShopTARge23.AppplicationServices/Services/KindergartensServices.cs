using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Dto;
using ShopTARge23.Data;
using ShopTARge23.Core.Domain;
using ShopTARge23.Core.ServiceInterface;


namespace ShopTARge23.ApplicationServices.Services
{
    public class KindergartensServices : IKindergartensServices
    {
        private readonly ShopTARge23Context _context;

        public KindergartensServices
            (
            ShopTARge23Context context
            )
        {
            _context = context;
        }
        public async Task<Kindergarten> Create(KindergartenDto dto)
        {
            Kindergarten kindergarten = new Kindergarten();

            kindergarten.Id = Guid.NewGuid();
            kindergarten.GroupName = dto.GroupName;
            kindergarten.ChildrenCount = dto.ChildrenCount;
            kindergarten.KindergartenName = dto.KindergartenName;
            kindergarten.Teacher = dto.Teacher;
            kindergarten.CreatedAt = DateTime.Now;
            kindergarten.UpdatedAt = DateTime.Now;

            await _context.Kindergartens.AddAsync(kindergarten);
            await _context.SaveChangesAsync();

            return kindergarten;
        }

        public async Task<Kindergarten> DetailAsync(Guid id)
        {
            var result = await _context.Kindergartens
                   .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
    }

 }
