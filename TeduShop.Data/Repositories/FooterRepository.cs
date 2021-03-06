﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

	public interface IFooterRepository : IRepository<Footer>
	{

		IEnumerable<Footer> GetByAlias(string alias);

	}

	public class FooterRepository :RepositoryBase<Footer>
	{
		public FooterRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}
	}
}
