using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FinalEvanyeline.Models;

namespace FinalEvanyeline.Pages.Login
{
    public class LocalAuthenticationStateProvider : AuthenticationStateProvider
    {

        private readonly ISessionStorageService _storageService;

        public LocalAuthenticationStateProvider(ISessionStorageService storageService)
        {
            _storageService = storageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            Usuario xusuario = await _storageService.GetItemAsync<Usuario>("usuario");
            ClaimsIdentity identity;

            if (xusuario != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                     new Claim(ClaimTypes.Name, xusuario.nombre),
                    new Claim(ClaimTypes.Email, xusuario.Email),
                    new Claim(ClaimTypes.Role, xusuario.Role),
                    new Claim(ClaimTypes.NameIdentifier,xusuario.idUsuario.ToString()),
                }, "apiauth_type");

            }
            else
            {
                identity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,"anonimo"),
                    new Claim(ClaimTypes.Email,"anonimo@gmail.com"),
                     new Claim(ClaimTypes.Role,"user"),
                }, "Anonimo");
            }

            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAuthenticaded(Usuario xuser)
        {
            var identity = new ClaimsIdentity(new[]
               {
                     new Claim(ClaimTypes.Name, xuser.nombre),
                    new Claim(ClaimTypes.Email, xuser.Email),
                    new Claim(ClaimTypes.Role, xuser.Role),
                    new Claim(ClaimTypes.NameIdentifier,xuser.idUsuario.ToString()),
                }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        public void MarkUserLogout()
        {
            _storageService.RemoveItemAsync("usuario");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
