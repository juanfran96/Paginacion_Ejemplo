using BlazorCRUD.Server.Helpers;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PersonasController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PersonasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            return await context.Personas.ToListAsync();
        }



        
        [HttpGet]
        [AllowAnonymous]

        ////creamos una clase paginación para  tener el dato del tamaño de la consulta y saber a que página pertenece 
        ///esa parte de  la consulta, además mostar el total de páginas que se tienen en la consulta por medio de la 
        ///cabecera de respuesta http
        public async Task<ActionResult<List<Persona>>> Get([FromQuery] Paginacion paginacion, 
            [FromQuery] string nombre)
        {
            var queryable = context.Personas.AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                queryable = queryable.Where(x => x.Nombre.Contains(nombre));
            }
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadAMostrar);
            return await queryable.Paginar(paginacion).ToListAsync();
        }
        
        [AllowAnonymous]
        [HttpGet("{id}", Name = "obtenerPersona")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            return await context.Personas.Include(x => x.Estado).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Persona persona)
        {
            context.Add(persona);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerPersona", new { id = persona.Id }, persona);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Persona persona)
        {
            context.Entry(persona).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var persona = new Persona { Id = id };
            context.Remove(persona);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
