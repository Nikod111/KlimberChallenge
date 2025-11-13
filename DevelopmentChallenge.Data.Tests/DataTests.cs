using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.FormasGeometrica;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var resumen = ReporteFormas.Imprimir(new List<FormaGeometrica>(), new Castellano());
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var resumen = ReporteFormas.Imprimir(new List<FormaGeometrica>(), new Ingles());
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Trapecio(10, 5, 8),
                new Rectangulo(10, 5)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>1 Círculo | Area 7,07 | Perimetro 9,42 <br/>1 Triángulo | Area 6,93 | Perimetro 12 <br/>1 Trapecio | Area 60 | Perimetro 31,76 <br/>1 Rectángulo | Area 50 | Perimetro 30 <br/>TOTAL:<br/>5 formas Perimetro 103,19 Area 149",
                resumen);
        }

        [TestCase]
        public void TestResumenConTrapecioYRectanguloEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(6, 4, 3),
                new Rectangulo(4, 2),
                new Cuadrado(2)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Italiano());

            Assert.IsTrue(resumen.Contains("Rapporto di Forme"));
            Assert.IsTrue(resumen.Contains("Trapezio"));
            Assert.IsTrue(resumen.Contains("Rettangolo"));
            Assert.IsTrue(resumen.Contains("Quadrato"));
        }
    }
}
