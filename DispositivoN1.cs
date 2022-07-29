using System;

public class Dispositivo1:OrdenBase

{
    public override string reparacion()
    {
    var Arreglar = "Telefono repara.....";
    return Arreglar;
    }
   public override string Adiciono()
   {
    var ArreglaRR = "Se agrego un adicional";
    return ArreglaRR;
    }
}