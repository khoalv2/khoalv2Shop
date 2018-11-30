using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

	public interface IMenuGroupRepository : IRepository<MenuGroup>
	{

		IEnumerable<MenuGroup> GetByAlias(string alias);

	}

	public class MenuGroupRepository :RepositoryBase<MenuGroup>
	{
		public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
		{

		}
	}
}
