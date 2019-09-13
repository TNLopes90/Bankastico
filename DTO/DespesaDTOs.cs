namespace Bankastico.DTO
{
	public class DespesaDTOs
	{		
	}

	public class InsertDespesaDTO
	{
		public int id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }
		public int IdCategoria { get; set; }		
	}

	public class ListDespesaDTO
	{
		public int id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }
		public string NomeCategoria { get; set; }		
	}
}