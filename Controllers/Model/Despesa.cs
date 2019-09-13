namespace Bankastico.Model
{
		public class Despesa
		{
				public int Id { get; set; }
				public string Titulo { get; set; }
				public string Descricao { get; set; }
				public decimal Valor { get; set; }
				public int IdCategoria { get; set; }
				public Categoria Categoria { get; set; }
		}
}