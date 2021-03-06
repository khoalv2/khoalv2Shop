﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

	public interface IProductTagRepository : IRepository<ProductTag>
	{

		IEnumerable<ProductTag> GetByAlias(string alias);

	}

	public	class ProductTagRepository:RepositoryBase<ProductTag>
	{
		public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}
	}
}
