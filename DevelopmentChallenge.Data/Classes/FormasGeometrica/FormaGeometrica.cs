namespace DevelopmentChallenge.Data.Classes.FormasGeometrica
{
    public abstract class FormaGeometrica
    {
        public abstract string Nombre { get; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
