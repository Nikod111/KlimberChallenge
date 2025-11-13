using DevelopmentChallenge.Data.Classes.FormasGeometrica;
using System;

public class Trapecio : FormaGeometrica
{
    private readonly decimal _baseMayor, _baseMenor, _altura;
    public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
    {
        _baseMayor = baseMayor; _baseMenor = baseMenor; _altura = altura;
    }
    public override string Nombre => "Trapecio";
    public override decimal CalcularArea() => ((_baseMayor + _baseMenor) / 2) * _altura;
    public override decimal CalcularPerimetro()
    {
        var lado = (decimal)Math.Sqrt(Math.Pow((double)(_baseMayor - _baseMenor) / 2, 2) + Math.Pow((double)_altura, 2));
        return _baseMayor + _baseMenor + 2 * lado;
    }
}