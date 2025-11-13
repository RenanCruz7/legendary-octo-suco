using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services;

public class UsuarioService
{
    private readonly IMapper _mapper;
    private readonly UserManager<Usuario> _userManager;

    public UsuarioService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IdentityResult> CadastrarUsuario(CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

        return resultado;
    }
}
