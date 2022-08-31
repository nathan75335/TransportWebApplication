
using TransportApp.Domain;

namespace TransportApp.Application.Repositories
{
    public interface IStreetRepository
    {
        Task<Street>  CreateNewStreetAsync(Street street);

        Task<List<Street>> GetListStreetAsync();

        Task<Street> UpdateStreetAsync(int id);

        Task<Street> DeleteStreetAsync(int id);
    }
}
