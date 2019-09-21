using System.Linq;
using Bankastico.Data;
using Bankastico.Model;

namespace Bankastico.Repositories
{
		public class CategoriaRepository
		{
				private readonly DataContext _dataContext;

				public CategoriaRepository(DataContext dataContext) => this._dataContext = dataContext;

				public void Save(Categoria categoria)
				{
					this._dataContext.Categorias.Add(categoria);
					this._dataContext.SaveChanges();
				}

				public Categoria FindCategoria(decimal idCategoria)
				{
					return this._dataContext.Categorias.Find(idCategoria);
				}

				public IQueryable<Categoria> ListCategorias()
				{
					return this._dataContext.Categorias;
				}
		}
}