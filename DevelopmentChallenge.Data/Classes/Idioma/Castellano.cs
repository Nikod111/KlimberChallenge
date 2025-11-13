using System.Collections.Generic;

public class Castellano : IIdioma
{
    public string Header => "<h1>Reporte de Formas</h1>";
    public string ListaVacia => "<h1>Lista vacía de formas!</h1>";
    public string Linea(int c, string n, decimal a, decimal p) =>
        $"{c} {n} | Area {a:#.##} | Perimetro {p:#.##} <br/>";
    public string Footer(int total, decimal p, decimal a) =>
        $"TOTAL:<br/>{total} formas Perimetro {p:#.##} Area {a:#.##}";
    public string Traducir(string forma, int c)
    {
        var traducciones = new Dictionary<string, (string Singular, string Plural)>
        {
            ["Cuadrado"] = ("Cuadrado", "Cuadrados"),
            ["Círculo"] = ("Círculo", "Círculos"),
            ["Triángulo"] = ("Triángulo", "Triángulos"),
            ["Trapecio"] = ("Trapecio", "Trapecios"),
            ["Rectángulo"] = ("Rectángulo", "Rectángulos")
        };

        if (traducciones.TryGetValue(forma, out var traduccion))
            return c == 1 ? traduccion.Singular : traduccion.Plural;

        return forma;
    }

}