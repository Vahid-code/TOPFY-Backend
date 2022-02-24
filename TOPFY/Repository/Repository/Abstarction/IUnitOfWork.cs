using System.Threading.Tasks;
using Repository.Repository.Abstarction;

namespace Repository.Services.Abstarction
{
    public interface IUnitOfWork
    {
        public IPostRepository Posts { get;}
        public ITagRepository Tags { get;}
        public IUserConnectionRepository UserConnections { get;}
        Task CompleteAsync();
        void Dispose();
    }
}