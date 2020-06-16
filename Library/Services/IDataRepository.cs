using Microsoft.EntityFrameworkCore;
using Library.Contexts;
using Library.Data;
using Library.Models;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Library.Services
{
    public interface IDataRepository<TSource> where TSource : BaseModel<TSource>
    {
        Task<IEnumerable<TResponse>> GetModels<TResponse>(FilterParams filter) where TResponse : ResponseDTO<TResponse>;
        Task<IEnumerable<TResponse>> GetModels<TResponse>() where TResponse : ResponseDTO<TResponse>;
        Task<TResponse> GetModelById<TResponse>(Guid id) where TResponse : ResponseDTO<TResponse>;
        Task<TResponse> UpdateModel<TRequest, TResponse>(TRequest model) where TRequest : RequestDTO<TRequest> where TResponse : ResponseDTO<TResponse>;
        Task<TResponse> CreateModel<TRequest, TResponse>(TRequest model) where TRequest : RequestDTO<TRequest> where TResponse : ResponseDTO<TResponse>;
        void DeleteModel(Guid id);
    }

    public class DataRepository<TSource, TContext> : IDataRepository<TSource> where TSource : BaseModel<TSource> where TContext : ApplicationContext
    {
        private readonly TContext _context;
        private readonly IMapper _mapper;

        public DataRepository(TContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<TResponse> CreateModel<TRequest, TResponse>(TRequest model) where TRequest : RequestDTO<TRequest> where TResponse : ResponseDTO<TResponse>
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetModelById<TResponse>(Guid id) where TResponse : ResponseDTO<TResponse>
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TResponse>> GetModels<TResponse>(FilterParams filter) where TResponse : ResponseDTO<TResponse>
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TResponse>> GetModels<TResponse>() where TResponse : ResponseDTO<TResponse>
        {
            List<TSource> entries = await _context.Set<TSource>().ToListAsync();
            List<TResponse> result = new List<TResponse>();
            entries.ForEach(item => result.Add(_mapper.Map<TResponse>(item)));
            return result;
        }

        public Task<TResponse> UpdateModel<TRequest, TResponse>(TRequest model) where TRequest : RequestDTO<TRequest> where TResponse : ResponseDTO<TResponse>
        {
            throw new NotImplementedException();
        }
    }
}