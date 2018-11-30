﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{

	public interface ISupportOnlineRepository : IRepository<SupportOnline>
	{

		IEnumerable<SupportOnline> GetByAlias(string alias);

	}


	public	class SupportOnlineRepository:RepositoryBase<SupportOnline>
	{
		public SupportOnlineRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}
	}
}
