namespace DevelopmentChallenge.Data.Classes.FormasGeometrica
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado) => _lado = lado;
        public override string Nombre => "Cuadrado";
        public override decimal CalcularArea() => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;
    }
}
