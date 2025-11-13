using DevelopmentChallenge.Data.Classes.FormasGeometrica;
using System;

public class TrianguloEquilatero : FormaGeometrica
{
    private readonly decimal _lado;
    public TrianguloEquilatero(decimal lado) => _lado = lado;
    public override string Nombre => "Triángulo";
    public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
    public override decimal CalcularPerimetro() => _lado * 3;
}