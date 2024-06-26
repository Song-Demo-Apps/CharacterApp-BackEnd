using CharacterApp.Models;

namespace CharacterApp.Services;

public interface ISpeciesService
{
    public Task<List<Species>> GetAllSpeciesAsync(int offset, int limit);
    public Task<Species?> GetSpeciesByIdAsync(int id);
    public Task<Species?> UpdateSpeciesAsync(Species species);
    public Task<Species> CreateSpeciesAsync(Species species);
    public Task<Species?> DeleteSpeciesAsync(int id);

}