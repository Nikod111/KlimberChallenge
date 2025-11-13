using DevelopmentChallenge.Data.Classes.FormasGeometrica;
using System;

public class Circulo : FormaGeometrica
{
    private readonly decimal _diametro;
    public Circulo(decimal diametro) => _diametro = diametro;
    public override string Nombre => "Círculo";
    public override decimal CalcularArea() => (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
    public override decimal CalcularPerimetro() => (decimal)Math.PI * _diametro;
}