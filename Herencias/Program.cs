using Herencias.Clases;

Persona objPersona1 = new Persona("0943561177", "Levis", "Mieller", new DateOnly(1998, 7, 18));

Console.WriteLine("Persona 1");
objPersona1.saludar();

Console.WriteLine();
Console.WriteLine("Estudiante 1");
Estudiante objEstudiante1 = new Estudiante("0943561177", "Levis", "Mieller", new DateOnly(1998, 7, 18), "Desarrollo de Software", 2);
objEstudiante1.saludar();
objEstudiante1.estudiar();

Console.WriteLine();
Console.WriteLine("Docente 1");
Docente objDocente1 = new Docente("0943561177", "Levis", "Mieller", new DateOnly(1998, 7, 18), "Programación", 5);
objDocente1.saludar();
objDocente1.enseñar();


Console.WriteLine();
Console.WriteLine("Director 1");
DirectorCarrera objDirectorCarrera = new DirectorCarrera("0943561177", "Levis", "Miller", new DateOnly(1998, 7, 18), "Programación", 5, "Ingeniería de Software");
objDirectorCarrera.saludar();
objDirectorCarrera.enseñar();
objDirectorCarrera.dirigir();


Console.ReadLine();
