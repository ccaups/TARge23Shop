using ShopTARge23.Core.Domain;

namespace ShopTARge23.Core.Servicesinerface
{
    public interface ISpaceshipsServices
    {
        Task<Spaceship> DetailAsync(Guid Id);
    }
}
