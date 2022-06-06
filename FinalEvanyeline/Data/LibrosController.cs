using FinalEvanyeline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Data
{
    public class LibrosController:Controller
    {
        private readonly DBContext _librosContext;

        public LibrosController(DBContext librosContext)
        {
            _librosContext = librosContext;
        }

        public async Task<List<Libros>> Get()
        {
            return await _librosContext.libros.ToListAsync();

        }
        public async Task<Libros> CrearLibro(Libros libro_nuevo)
        {
            var Ultimo = _librosContext.libros.Max(x => x.idlibro) + 1;
            libro_nuevo.idlibro = Ultimo;

            await _librosContext.libros.AddAsync(libro_nuevo);
            await _librosContext.SaveChangesAsync();
            return libro_nuevo;

        }
        public async Task<Libros> ObtenerLibroPorId(int Libroid)
        {
            var LibroDB = await _librosContext.libros.FindAsync(Libroid);
            if (LibroDB == null)
            {
                return new Libros();
            }
            return LibroDB;

        }


        public async Task<Libros> Actualizar(int LibrosId, Libros librosupdate)
        {
            var LibroDB = await _librosContext.libros.FindAsync(LibrosId);

            LibroDB.nombre = librosupdate.nombre;
            LibroDB.editorial= librosupdate.editorial;
            LibroDB.autor = librosupdate.autor;
            LibroDB.genero = librosupdate.genero;
            LibroDB.nombre = librosupdate.nombre;
            LibroDB.precio = librosupdate.precio;
            LibroDB.Cant_disponible = librosupdate.Cant_disponible;


            await _librosContext.SaveChangesAsync();
            return LibroDB;
        }

        public async Task<Libros> ActualizarCantidad(int LibrosId, Libros librosupdate)
        {
            var LibroDB = await _librosContext.libros.FindAsync(LibrosId);

           
            LibroDB.Cant_disponible = librosupdate.Cant_disponible;


            await _librosContext.SaveChangesAsync();
            return LibroDB;
        }

        public async Task<List<Libros>> FiltroporDisponibilidad()
        {

            return await _librosContext.libros.Where(x => x.Cant_disponible > 0).ToListAsync();

        }

    }
}
