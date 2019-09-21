using Bankastico.Data;
using Bankastico.Model;
using System.Linq;

namespace Bankastico.Repositories
{
		public class DespesaRepository
		{
			private readonly DataContext _dataContext;

			public DespesaRepository(DataContext dataContext) => this._dataContext = dataContext;

			public void Save(Despesa despesa)
			{
				this._dataContext.Despesas.Add(despesa);
				this._dataContext.SaveChanges();
			}

			public IQueryable<Despesa> FindDespesasByCategoria(Categoria categoria)
			{
				return this._dataContext.Despesas
					.Where(d => d.IdCategoria == categoria.Id);
			}
		}
}