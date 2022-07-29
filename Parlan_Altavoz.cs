using System;

public class Parlan_Altavoz: Decorador{

    public Parlan_Altavoz (OrdenBase ordenBase):base(ordenBase)
    {
        //
    }

    public override string Adiciono()
    {
        var teclado = orden.Adiciono();
        Console.WriteLine("Adicion de parlante y/o altavoz");
        return teclado;
    }
}