using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpPNetAPI.Models;


namespace CSharpPNetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly pruebaContext pruebaContext; // Instancia para poder realizar las operaciones CRUD
        public ClienteController(pruebaContext pruebaContext)
        {
            this.pruebaContext = pruebaContext;
            
        }
        //API para Listar los registros de la tabla Cliente
        [HttpGet]
        [Route("ListaClientes")]
        public IActionResult ListaClientes() { 
            List<Cliente> lista = new List<Cliente>();
            try
            {
                lista = this.pruebaContext.Clientes.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }


    }
}
