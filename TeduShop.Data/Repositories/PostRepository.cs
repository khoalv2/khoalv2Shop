﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{


	public interface IPostRepository :IRepository<Post>
	{

		IEnumerable<Post> GetByAlias(string alias);

	}

	public class PostRepository :RepositoryBase<Post>
	{
		public PostRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}
	}
}
