using System.Collections.Generic;

public class Italiano : IIdioma
{
    public string Header => "<h1>Rapporto di Forme</h1>";
    public string ListaVacia => "<h1>Lista vuota di forme!</h1>";
    public string Linea(int c, string n, decimal a, decimal p) =>
        $"{c} {n} | Area {a:#.##} | Perimetro {p:#.##} <br/>";
    public string Footer(int total, decimal p, decimal a) =>
        $"TOTALE:<br/>{total} forme Perimetro {p:#.##} Area {a:#.##}";
    public string Traducir(string forma, int c)
    {
        var traducciones = new Dictionary<string, (string Singular, string Plural)>
        {
            ["Cuadrado"] = ("Quadrato", "Quadrati"),
            ["Círculo"] = ("Cerchio", "Cerchi"),
            ["Triángulo"] = ("Triangolo", "Triangoli"),
            ["Trapecio"] = ("Trapezio", "Trapezi"),
            ["Rectángulo"] = ("Rettangolo", "Rettangoli")
        };

        if (traducciones.TryGetValue(forma, out var traduccion))
            return c == 1 ? traduccion.Singular : traduccion.Plural;

        return forma;
    }

}