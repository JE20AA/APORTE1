public class Cargador : Decorador
{

    public Cargador(OrdenBase ordenBase) : base(ordenBase) { }

    public override string extension()
    {
        var teclado = orden.Extension();
        Console.WriteLine("Haz agregado un cargador");
        return teclado;
    }
}
