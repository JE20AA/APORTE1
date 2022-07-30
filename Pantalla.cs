public class Pantalla : Decorador
{

    public Pantalla(OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string reparar()
    {
        var repacion = "Reparar pantalla que está rota";
        return repacion;
    }
}