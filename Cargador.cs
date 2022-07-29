using System;

public class Cargador: Decorador
{
    
    public Cargador(OrdenBase ordenBase):base(ordenBase)
    {
        //
    }
    public override string Adiciono()
    {
        var Variable = orden.Adiciono();
        Console.WriteLine("Se añadio cargador adicional");
      return Variable;
    }
}