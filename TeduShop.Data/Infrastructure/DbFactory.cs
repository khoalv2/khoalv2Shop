using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		private TeduShopDBContext dbContext;

		public TeduShopDBContext Init()
		{
			return dbContext ?? (dbContext = new TeduShopDBContext());
		}

		protected override void DisposeCore()
		{
			if (dbContext != null)
				dbContext.Dispose();
		}
	}
}
