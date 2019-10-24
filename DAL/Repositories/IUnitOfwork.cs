using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IUnitOfwork
    {
        Task<int> Complete();
    }
}