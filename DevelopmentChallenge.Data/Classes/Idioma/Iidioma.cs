public interface IIdioma
{
    string Traducir(string forma, int cantidad);
    string Header { get; }
    string Footer(int totalFiguras, decimal perimetro, decimal area);
    string Linea(int cantidad, string nombre, decimal area, decimal perimetro);
    string ListaVacia { get; }
}