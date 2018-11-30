﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory dbFactory;
		private TeduShopDBContext dbContext;

		public UnitOfWork(IDbFactory dbFactory)
		{
			this.dbFactory = dbFactory;
		}

		public TeduShopDBContext DbContext
		{
			get { return dbContext ?? (dbContext = dbFactory.Init()); }
		}

		public void Commit()
		{
			DbContext.SaveChanges();
		}
	}
}
