using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Infrasturcture.Repostiories;

public class ClothingRepository : IClothingRepository
{
    public Task<Clothing> AddAsync(Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Clothing> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Clothing> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Clothing> UpdateAsync(Clothing clothing)
    {
        throw new NotImplementedException();
    }

}
