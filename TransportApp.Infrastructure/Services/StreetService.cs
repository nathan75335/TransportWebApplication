
using TransportApp.Application.Repositories;
using TransportApp.Application.Services;
using TransportApp.Domain;

namespace TransportApp.Infrastructure.Services
{
    public class StreetService : IServiceStreet
    {
        private readonly IStreetRepository _streetRepository;

        public StreetService(IStreetRepository streetRepository)
        {
            _streetRepository = streetRepository;
        }
        public async Task<Street> CreateNewStreetAsync(Street street)
        {
            await _streetRepository.CreateNewStreetAsync(street);
            return street;

        }

        public async Task DeleteStreetAsync(int id)
        {
            await _streetRepository.DeleteStreetAsync(id);
         
        }

        public async Task<List<Street>> GetListStreetAsync()
        {
           var streets = await _streetRepository.GetListStreetAsync();
            return streets;
        }

        public async Task UpdateStreetAsync(int id)
        {
            await _streetRepository.UpdateStreetAsync(id);
        }
    }
}
