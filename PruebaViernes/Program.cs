using PruebaViernes;

Automovil Auto = new Automovil("Toyota", "ABC123", "Corolla", "Rojo", 50, 10);


Auto.ReabastecerCombustible(25);


Auto.Conducir(100);


bool puedeConducir = Auto.PuedeConducir(100);
Console.WriteLine($"El automóvil puede conducir 100 km: {puedeConducir}");

//Otro carro
Automovil Auto2 = new Automovil("Susuki", "ZZZ0002", "Alto", "Rojo", 45, 20);


Auto2.ReabastecerCombustible(35);


Auto.Conducir(200);


bool _puedeConducir = Auto.PuedeConducir(150);
Console.WriteLine($"El automóvil puede conducir 100 km: {puedeConducir}");