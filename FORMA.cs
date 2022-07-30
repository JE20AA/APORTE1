public class FORMA : Decorador
{

    public FORMA(OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string reparar()
    {
        var repacion = "Has agregado formartear tu celular";
        return repacion;
    }
}