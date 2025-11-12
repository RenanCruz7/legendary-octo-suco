using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;

namespace UsuariosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastrarUsuario(CreateUsuarioDto dto)
    {
        return Ok("Usuário cadastrado com sucesso!");
    }
}