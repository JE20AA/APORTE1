public class Dispo2 : OrdenBase
{
    public override string Reparar()
    {
        var repa = "Tu telefono ha sido reparado";
        return repa;
    }
    public override string Extension()
    {
       var reparar = "Desea agregar algo más?";
        return reparar; 
    }
}