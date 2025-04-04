using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IClothingRepository
{
    Task<Clothing> GetAllAsync();
    Task<Clothing> GetByIdAsync(int id);
    Task<Clothing> AddAsync(Clothing clothing);
    Task<Clothing> UpdateAsync(Clothing clothing);
    Task<bool> DeleteAsync(int id);
}
