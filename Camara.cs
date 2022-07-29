using System;

public class Camara: Decorador{

    public Camara(OrdenBase ordenBase):base(ordenBase)
    {
        //
    }

    public override string reparacion()
    {
    var Variable = orden.reparacion();
    Console.WriteLine("Opcion para areglar Camara");
    return Variable;
    }
}


