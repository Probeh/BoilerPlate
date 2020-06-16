using AutoMapper;
using Library.Contexts;
using Library.Models;
using Library.Services;

namespace WebAPI.Data
{
    public interface IApplicationRepository<TSource> : IDataRepository<TSource> where TSource : BaseModel<TSource> { }
    public class ApplicationRepository<TSource> : DataRepository<TSource, ApplicationContext>, IApplicationRepository<TSource> where TSource : BaseModel<TSource>
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public ApplicationRepository(ApplicationContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
