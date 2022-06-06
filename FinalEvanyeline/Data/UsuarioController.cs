using FinalEvanyeline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Data
{
    public class UsuarioController:Controller
    {
        private readonly DBContext _usuariosContext;

        public UsuarioController(DBContext usuariosContext)
        {
            _usuariosContext = usuariosContext;
        }

        public async Task<List<Usuario>> Get()
        {
            return await _usuariosContext.UsuarioLibro.ToListAsync();

        }
        public async Task<Usuario> CrearUsuario(Usuario usuario_nuevo)
        {
            var Ultimo = _usuariosContext.UsuarioLibro.Max(x => x.idUsuario) + 1;
            usuario_nuevo.idUsuario = Ultimo;

            await _usuariosContext.UsuarioLibro.AddAsync(usuario_nuevo);
            await _usuariosContext.SaveChangesAsync();
            return usuario_nuevo;

        }
        public async Task<Usuario> ObtenerUsuarioPorId(int UsuarioId)
        {
            var UsuarioDB = await _usuariosContext.UsuarioLibro.FindAsync(UsuarioId);
            if (UsuarioDB == null)
            {
                return new Usuario();
            }
            return UsuarioDB;

        }


        public async Task<Usuario> Actualizar(int UsuarioId, Usuario usuarioupdate)
        {
            var UsuarioDB = await _usuariosContext.UsuarioLibro.FindAsync(UsuarioId);

            UsuarioDB.nombre = usuarioupdate.nombre;
            UsuarioDB.contrasena = usuarioupdate.contrasena;
            UsuarioDB.Role = usuarioupdate.Role;


            await _usuariosContext.SaveChangesAsync();
            return UsuarioDB;
        }



        public async Task<List<Usuario>> ValidarUsuarioLogin(UserInfo usuario)
        {
            return await _usuariosContext.UsuarioLibro.Where(x => x.Email == usuario.Email && x.contrasena == usuario.Passoword).ToListAsync();

        }
    }
}
