using Bankastico.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bankastico.Controllers
{
		public class DespesaController : ControllerBase
		{
			
			[Route("")]
			[HttpPost]
			public void Post(Despesa Despesa)
			{

			}

			[Route("")]
			[HttpGet]
			public Despesa Get(int id)
			{
				return new Despesa();
			}
		}
}