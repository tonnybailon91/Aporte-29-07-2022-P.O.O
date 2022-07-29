using System;
public class Decorador
{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string Adiciono ()
    {
      return orden.Adiciono();
    }
    public virtual string reparacion(){
      return orden.Adiciono();
    }
}