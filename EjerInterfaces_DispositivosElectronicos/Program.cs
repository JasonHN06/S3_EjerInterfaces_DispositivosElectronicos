using EjerInterfaces_DispositivosElectronicos;

Telefono telefono = new Telefono();
telefono.Marca = "Samsung";
telefono.Modelo = "Galaxy S25";
telefono.Apagar();

Laptop laptop = new Laptop();
laptop.Marca = "Lenovo";
laptop.Modelo = "IdeaPad 3";
laptop.Apagar();
laptop.NivelBateria = 95;

Console.WriteLine();
Console.WriteLine("*** Estado inicial de los dispositivos ***");
telefono.MostrarEstado();
laptop.MostrarEstado();
Console.WriteLine();

Console.WriteLine("Encendiendo los dispositivos...");
telefono.Encender();
laptop.Encender();
Console.WriteLine();

Console.WriteLine("*** Estado actual de los dispositivos ***");
telefono.MostrarEstado();
laptop.MostrarEstado();
Console.WriteLine();

Console.WriteLine("Apagando los dispositivos...");
telefono.Apagar();
laptop.Apagar();
Console.WriteLine();

Console.WriteLine("*** Estado final de los dispositivos ***");
telefono.MostrarEstado();
laptop.MostrarEstado();
Console.WriteLine();
