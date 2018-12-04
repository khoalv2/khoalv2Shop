using System;
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

		//IEnumerable<Post> GetByAlias(string alias);
		IEnumerable<Post> GetAllByTagPaging(string Tag, int Page, int PageSize, out int totalRow);


	}

	public class PostRepository :RepositoryBase<Post>,IPostRepository
	{
		public PostRepository(IDbFactory dbFactory):base(dbFactory)
		{

		}

		public IEnumerable<Post> GetAllByTagPaging(string Tag, int Page, int PageSize, out int totalRow)
		{
			var query = from p in DbContext.Posts
						join pt in DbContext.PostTags
						on p.ID equals pt.PostID
						where pt.TagID == Tag  & p.Status
						orderby p.CreatedDate descending
						select p;
			totalRow = query.Count();
			query = query.Skip((Page - 1) * PageSize).Take(PageSize);//chưa hiếu
			return query;
		}
	}
}
