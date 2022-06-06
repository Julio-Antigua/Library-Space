using FinalEvanyeline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Data
{
    public class AutoresController:Controller
    {

        private readonly DBContext _autoresContext;

        public AutoresController(DBContext autoresContext)
        {
            _autoresContext = autoresContext;
        }

        public async Task<List<Autores>> Get()
        {
            return await _autoresContext.autores.ToListAsync();

        }
        public async Task<Autores> CrearAutor(Autores autor_nuevo)
        {
            var Ultimo = _autoresContext.autores.Max(x => x.idAutor) + 1;
            autor_nuevo.idAutor = Ultimo;

            await _autoresContext.autores.AddAsync(autor_nuevo);
            await _autoresContext.SaveChangesAsync();
            return autor_nuevo;

        }
        public async Task<Autores> ObtenerAutorPorId(int AutorID)
        {
            var AutorDB = await _autoresContext.autores.FindAsync(AutorID);
            if (AutorDB == null)
            {
                return new Autores();
            }
            return AutorDB;

        }


        public async Task<Autores> Actualizar(int AutorID, Autores autoresoupdate)
        {
            var UsuarioDB = await _autoresContext.autores.FindAsync(AutorID);

            UsuarioDB.edad = autoresoupdate.edad;
            UsuarioDB.nombre_autor = autoresoupdate.nombre_autor;
            UsuarioDB.estado = autoresoupdate.estado;


            await _autoresContext.SaveChangesAsync();
            return UsuarioDB;
        }
    }
}
