using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{

	public interface IPostService
	{
		void Add(Post post);
		void Update(Post post);
		void Delete(int id);
		IEnumerable<Post> GetAll();
		IEnumerable<Post> GetAllPaging(int Page, int PageSize, out int totalRow);
		Post GetById(int id);
		IEnumerable<Post> GetAllByTagPaging(string Tag, int Page, int PageSize, out int totalRow);
		void SaveChange();


	}
	public class PostService : IPostService
	{
		IPostRepository _postRepository;
		IUnitOfWork _unitOfWork;


		public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork )
		{
			this._postRepository = postRepository;
			this._unitOfWork = unitOfWork;

		}


		public void Add(Post post)
		{
			_postRepository.Add(post);


		}

		public void Delete(int id)
		{

			_postRepository.Delete(id);
		}

		public IEnumerable<Post> GetAll()
		{
			return _postRepository.GetAll(new string[] {"PostCategory"});
		}


		public IEnumerable<Post> GetAllByTagPaging(string Tag, int Page, int PageSize, out int totalRow)
		{
			return _postRepository.GetMultiPaging(x=>x.Status,out totalRow, Page,PageSize);
		}

		public IEnumerable<Post> GetAllPaging(int Page, int PageSize, out int totalRow)
		{
			return _postRepository.GetMultiPaging(x => x.Status, out totalRow, Page, PageSize);
		}

		public Post GetById(int id)
		{

		 return	_postRepository.GetSingleById(id);
		}

		public void SaveChange()
		{
			 _unitOfWork.Commit();
		}

		public void Update(Post post)
		{
			 _postRepository.Update(post);
		}
	}
}
