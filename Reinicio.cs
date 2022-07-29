using System;

public class Reinicio: Decorador
{

    public Reinicio (OrdenBase ordenBase):base(ordenBase)
    {
        //
    }
    public virtual string reparacion()
    {
        var repacion = "Se le realizara el reinicio al equipo";
          return repacion;
    }
}