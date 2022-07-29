using System;

internal class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Cliente Tucker");
        var Aparato1 = new Dispositivo1();
        var reparacion1 = new Pantalla(Aparato1 );
        Console.WriteLine(""+reparacion1.reparacion());
        var reparacion2 = new Liquidos(Aparato1);
        Console.WriteLine(""+reparacion2.reparacion());
        var reparacion3 = new Reinicio(Aparato1);
        Console.WriteLine(""+reparacion3.reparacion());
        var reparacion4 = new Camara(Aparato1);
        Console.WriteLine(""+reparacion4.reparacion());
        var cargador = new Cargador(Aparato1);
        Console.WriteLine(""+cargador.Adiciono()+".\n");


    Console.WriteLine("Cliente Tonny");
    var Aparato2 = new DispositivoN2();
    var Parareparacion = new Liquidos(Aparato2);
    Console.WriteLine(""+Parareparacion.reparacion());
    var Parareparacion1 = new Reinicio(Aparato2);
    Console.WriteLine(""+Parareparacion1.reparacion());
    var Pararlante = new Parlan_Altavoz(Aparato2);
    Console.WriteLine(""+Pararlante.Adiciono()+".\n");
     


        Console.WriteLine("Cliente Gabriel");
        var Aparato3 = new DispositivoN3();
        var Auriculares1 = new Auriculares(Aparato3);
        Console.WriteLine(""+Auriculares1.Adiciono());
        var cargador1 = new Cargador(Aparato1);
        Console.WriteLine(""+cargador1.Adiciono()+".\n");


    }
}