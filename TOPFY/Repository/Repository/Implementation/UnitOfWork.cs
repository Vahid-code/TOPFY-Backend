using Microsoft.Extensions.Logging;
using Repository.DAL;
using Repository.Repository.Abstarction;
using Repository.Repository.Implementation;
using Repository.Services.Abstarction;
using System;
using System.Threading.Tasks;


namespace Repository.Services.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;
        public IPostRepository Posts { get; private set; }
        public ITagRepository Tags { get; private set; }
        public IUserConnectionRepository UserConnections { get; private set; }
        public UnitOfWork(AppDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            Posts = new PostRepository(_context,_logger);
            Tags = new TagRepository(_context,_logger);
            UserConnections = new UserConnectionRepository(_context, _logger);
        }

        public async Task CompleteAsync()=>await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}