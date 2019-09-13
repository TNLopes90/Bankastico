using Bankastico.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bankastico.Controllers
{
	public class CategoriaController : ControllerBase
	{

		[Route("CategoriaController")]
		[HttpPost]
		public void Post(Categoria categoria)
		{

		}

		[Route("CategoriaController")]
		[HttpGet]
		public Categoria Get(int id)
		{
			return new Categoria();
		}

	}
}