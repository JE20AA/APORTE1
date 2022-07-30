public class Auriculares : Decorador
{

    public Auriculares (OrdenBase ordenBase) : base(ordenBase) { }

    public override string extension()
    {
        var teclado = orden.Extension();
        Console.WriteLine("Has agregado un auricular en tu reparación");
        return teclado;
    }
}
