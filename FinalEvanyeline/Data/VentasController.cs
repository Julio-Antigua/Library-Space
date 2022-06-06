using FinalEvanyeline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvanyeline.Data
{
    public class VentasController:Controller
    {

        private readonly DBContext _ventasContext;
        private readonly DBContext _libroscontext;

        public VentasController(DBContext ventasContext)
        {
            _ventasContext = ventasContext;
        }

        public async Task<List<Ventas>> Get()
        {
            return await _ventasContext.ventas.ToListAsync();

        }
        public async Task<Ventas> CrearVentas(Ventas ventas_nuevo)
        {
            var Ultimo = _ventasContext.ventas.Max(x => x.idVentas) + 1;
            ventas_nuevo.idVentas = Ultimo;

            await _ventasContext.ventas.AddAsync(ventas_nuevo);
            await _ventasContext.SaveChangesAsync();
            return ventas_nuevo;

        }

        public async Task<List<Ventas>> FiltroporFecha(DateTime Fecha1)
        {
           
            return await _ventasContext.ventas.Where(x => x.ventas_fecha == Fecha1).ToListAsync();

        }

       
    }
}
