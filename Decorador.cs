using System;
public class Decorador
{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden = orden;
    }
    public virtual string extension()
    {
        return orden.Extension();
    }
    public virtual string Reparar()
    {
        return orden.Extension();
    }
}
