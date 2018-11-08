﻿using System.Threading.Tasks;

namespace Catalog.API.Model
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity, bool saveChanges = true);
        Task<T> UpdateAsync(T entity, bool saveChanges);
        Task<bool?> DeleteAsync(int id, bool saveChanges = true);
    }
}