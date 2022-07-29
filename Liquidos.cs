using System;

public class Liquidos: Decorador
{

    public Liquidos(OrdenBase ordenBase):base(ordenBase)
    {
        //
    }
    public virtual string reparacion()
    {
        var repacion = "Opcion de reparacion daño por liquidos";
          return repacion;
    }
}