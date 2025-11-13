/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

/*
 * Programador: Nicolás Domínguez
 */

using DevelopmentChallenge.Data.Classes.FormasGeometrica;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteFormas
    {
        public static string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            if (!formas.Any()) return idioma.ListaVacia;

            var sb = new StringBuilder();
            sb.Append(idioma.Header);

            var grupos = formas.GroupBy(f => f.Nombre);
            decimal totalPerimetro = 0, totalArea = 0;
            int totalFormas = 0;

            foreach (var grupo in grupos)
            {
                var cantidad = grupo.Count();
                var area = grupo.Sum(f => f.CalcularArea());
                var perimetro = grupo.Sum(f => f.CalcularPerimetro());
                sb.Append(idioma.Linea(cantidad, idioma.Traducir(grupo.Key, cantidad), area, perimetro));
                totalFormas += cantidad;
                totalArea += area;
                totalPerimetro += perimetro;
            }

            sb.Append(idioma.Footer(totalFormas, totalPerimetro, totalArea));
            return sb.ToString();
        }
    }
}