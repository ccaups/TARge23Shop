using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Dto;
using ShopTARge23.Data;
using ShopTARge23.Core.Domain;
using ShopTARge23.Core.ServiceInterface;

namespace ShopTARge23.ApplicationServices.Services
{
    public class RealEstateServices : IRealEstateServices
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
    }
}
