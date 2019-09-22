using AutoMapper;
using Bankastico.DTO;
using Bankastico.Model;
using static Bankastico.Data.CategoriaDTOs;

namespace Bankastico.Helper
{
	public class AutoMapperHelper : Profile
	{
			public AutoMapperHelper()
			{
				CreateMap<Categoria, InsertCategoriaDTO>();
				CreateMap<Despesa, InsertDespesaDTO>();
				CreateMap<Despesa, ListDespesaDTO>();
			}
	}
}