class Program{
    public static void Main(String[] args){

        //telefono (DISPOS1)

            var telefono = new Dispo1();

            var reparacion = new Pantalla(telefono);
            Console.WriteLine(""+reparacion.reparar());

            var reparacion2 = new Mica(telefono);
            Console.WriteLine(""+reparacion2.Reparar());

            var reparacion3 = new FORMA(telefono);
            Console.WriteLine(""+reparacion3.Reparar());

            var cargador = new Cargador(telefono);
            Console.WriteLine(""+cargador.extension());

        //telefono 2(DISPOSI2)
            var telefono2 = new Dispo2();

            var reparacion4 = new Mica(telefono);
            Console.WriteLine(""+reparacion4.Reparar());

            var reparacion5 = new FORMA(telefono);
            Console.WriteLine(""+reparacion5.reparar());

            var vocina = new Vocina(telefono);
            Console.WriteLine(""+ vocina.extension());


      //telefoNO (DISPOSI3)
            var telefono3 = new Dispo3();

            var auriculares = new Auriculares(telefono);
            Console.WriteLine(""+auriculares.extension());
    }
}