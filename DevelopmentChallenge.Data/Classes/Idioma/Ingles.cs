using System.Collections.Generic;

public class Ingles : IIdioma
{
    public string Header => "<h1>Shapes report</h1>";
    public string ListaVacia => "<h1>Empty list of shapes!</h1>";
    public string Linea(int c, string n, decimal a, decimal p) =>
        $"{c} {n} | Area {a:#.##} | Perimeter {p:#.##} <br/>";
    public string Footer(int total, decimal p, decimal a) =>
        $"TOTAL:<br/>{total} shapes Perimeter {p:#.##} Area {a:#.##}";
    public string Traducir(string forma, int c)
    {
        var traducciones = new Dictionary<string, (string Singular, string Plural)>
        {
            ["Cuadrado"] = ("Square", "Squares"),
            ["Círculo"] = ("Circle", "Circles"),
            ["Triángulo"] = ("Triangle", "Triangles"),
            ["Trapecio"] = ("Trapezoid", "Trapezoids"),
            ["Rectángulo"] = ("Rectangle", "Rectangles")
        };

        if (traducciones.TryGetValue(forma, out var traduccion))
        {
            return c == 1 ? traduccion.Singular : traduccion.Plural;
        }

        return forma;
    }

}