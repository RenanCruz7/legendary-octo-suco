using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly UsuarioService _usuarioService;

    public UsuarioController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
    {
        IdentityResult resultado = await _usuarioService.CadastrarUsuario(dto);

        if (resultado.Succeeded) 
        {
            return Ok("Usuario Cadastrado com sucesso");
        }
        return BadRequest(resultado.Errors);
    }
}