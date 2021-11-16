using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Server.Helpers
{
    public static class HttpContextExtensions
    {


        ///metodo generico para implementar la logica de paginación 
        public static async Task InsertarParametrosPaginacionEnRespuesta<T>(this HttpContext context,
            IQueryable<T> queryable, int cantidadRegistrosAMostrar)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            double conteo = await queryable.CountAsync();////// se obtinen el total de registro obtenidos 
            double totalPaginas = Math.Ceiling(conteo / cantidadRegistrosAMostrar);/// calculo del total de páginas a mostrar 
            context.Response.Headers.Add("totalPaginas", totalPaginas.ToString());
        }
    }
}
