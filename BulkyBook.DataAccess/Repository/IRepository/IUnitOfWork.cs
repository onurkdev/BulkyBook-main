using System;
namespace BulkyBook.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICoverTypeRepository CoverType { get; }
		ICategoryRepository Category { get; }
		IProductRepository Product { get; }
		ICompanyRepository Company { get; }
		IApplicationUserRepository ApplicationUser { get; }
		IShoppingCartRepository shoppingCart { get; }

		void Save();
	}
}

