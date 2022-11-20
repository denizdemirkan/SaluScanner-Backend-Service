using Microsoft.EntityFrameworkCore;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Repositories;
using SaluScanner.Core.Services;
using SaluScanner.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Service.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly IGenericRepository<TEntity> _genericRepository;
        protected readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<TEntity> _genericRepository, IUnitOfWork _unitOfWork)
        {
            this._genericRepository = _genericRepository;
            this._unitOfWork = _unitOfWork;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _genericRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;

        }

        public Task AddRangeAsyn(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _genericRepository.GetAll().ToListAsync();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
