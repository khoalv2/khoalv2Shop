using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{


	public interface IMenuRepository : IRepository<Menu>
	{

		IEnumerable<Menu> GetByAlias(string alias);

	}

	public class MenuRepository : RepositoryBase<Menu>
	{
		public MenuRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}


	}
}
