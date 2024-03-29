﻿namespace RelTransCustomer.Application.Contracts.Repositories;

public interface IGenericRepositoryAsync<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
}