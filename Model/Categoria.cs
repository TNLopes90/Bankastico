using System.Collections.Generic;

namespace Bankastico.Model
{
		public class Categoria
		{
				public int Id { get; set; }
				public string Titulo { get; set; }
				public IEnumerable<Despesa> Despesas { get; set; }
		}
}