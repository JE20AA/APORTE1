public class Vocina : Decorador
{

    public Vocina (OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string reparar ()
    {
        var repacion = "Arreglar vocina";
        return repacion;
    }
}