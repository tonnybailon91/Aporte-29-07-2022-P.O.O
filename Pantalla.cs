using System;

public class Pantalla: Decorador
{

    public Pantalla(OrdenBase ordenBase):base(ordenBase)
    {
        //
    }
    public virtual string reparacion()
    {
        var repacion = "Opcion de areglo de pantalla";
          return repacion;
    }
}



