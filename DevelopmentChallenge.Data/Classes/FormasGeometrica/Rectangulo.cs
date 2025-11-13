using DevelopmentChallenge.Data.Classes.FormasGeometrica;

public class Rectangulo : FormaGeometrica
{
    private readonly decimal _ancho, _alto;
    public Rectangulo(decimal ancho, decimal alto)
    {
        _ancho = ancho; _alto = alto;
    }
    public override string Nombre => "Rectángulo";
    public override decimal CalcularArea() => _ancho * _alto;
    public override decimal CalcularPerimetro() => 2 * (_ancho + _alto);
}