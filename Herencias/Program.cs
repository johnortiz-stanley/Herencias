using Herencias.Clases;

Persona objPersona1 = new Persona("0941517790", "John", "Ortiz", new DateOnly(1998, 7, 19));

Console.WriteLine("Persona 1");
objPersona1.saludar();

Console.WriteLine();
Console.WriteLine("Estudiante 1");
Estudiante objEstudiante1 = new Estudiante("0944567380", "Allan", "Zurtiz", new DateOnly(2000, 2, 15), "Robotica", 1);
objEstudiante1.saludar();
objEstudiante1.estudiar();

Console.WriteLine();
Console.WriteLine("Docente 1");
Docente objDocente1 = new Docente("0940987652", "Samuel", "Macias", new DateOnly(2001, 8, 7), "Derechos", 6);
objDocente1.saludar();
objDocente1.enseñar();


Console.WriteLine();
Console.WriteLine("Director 1");
DirectorCarrera objDirectorCarrera = new DirectorCarrera("0987651234", "Justin", "Bieber", new DateOnly(1997, 1, 3), "Artes", 5, "Artes musicales");
objDirectorCarrera.saludar();
objDirectorCarrera.enseñar();
objDirectorCarrera.dirigir();


Console.ReadLine();
