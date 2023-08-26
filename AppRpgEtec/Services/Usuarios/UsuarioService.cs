using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;

namespace AppRpgEtec.Services.Usuarios;


public class UsuarioService : Request

{
    private readonly Request _request;
    private const string apiUrlBase = "https://bsite.net/luizfernando987/Usuarios";

    public UsuarioService()
    {
        _request = new Request();
    }

    public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
    {
        string urlComplementar = "/Registar";
        u.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, u);
        return u;
    }

    public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
    {
        string urlComplementar = "/Autenticar";
        u = await _request.PostAsync(apiUrlBase + urlComplementar, u, string.Empty);
        return u;
    }
}
