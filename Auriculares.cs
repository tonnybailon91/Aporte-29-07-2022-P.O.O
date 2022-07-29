using System;

public class Auriculares: Decorador
{
    
    public Auriculares(OrdenBase ordenBase):base(ordenBase)
    {
        //
    }
    public override string Adiciono()
    {
        var Variable = orden.Adiciono();
        Console.WriteLine("Se añadio Auriculares");
      return Variable;
    }
}