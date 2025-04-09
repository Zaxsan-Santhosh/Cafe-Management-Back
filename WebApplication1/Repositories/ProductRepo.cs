using Microsoft.EntityFrameworkCore;
using WebApplication1.Databasse;
using WebApplication1.Entities;
using WebApplication1.IRepos;

namespace WebApplication1.Repositories
{
    public class ProductRepo /*: IProductRepo*/
    {
        
        private readonly AppDbContext _appDbContext;


        public ProductRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


       
    }
}
