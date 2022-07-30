public class Mica : Decorador
{

    public Mica(OrdenBase ordenBase) : base(ordenBase) { }

    public override string extension()
    {
        var teclado = orden.Extension();
        Console.WriteLine("Has agregado el una orden  adicional");
        return teclado;
    }
}