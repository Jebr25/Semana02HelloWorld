// See https://aka.ms/new-console-template for more information
using Semana02HelloWorld;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Ambiente Web";
int edad = 30;
double salario = 10000;

var alumno = "Jeber Linares";
var notaFinal = 19.50;

var persona = new Persona();
persona.Dni = 20404870;
persona.Telefono = "3178524";
persona.NombreCompleto = "Paolo Guerrero";
persona.Estado = true;

var persona2 = new Persona();
{ 
persona.Dni = 65218938;
persona.Telefono = "2926587";
persona.NombreCompleto = "Jeber Linares";
persona.Estado = true;
};

var persona3 = new Persona(23654897,"Alex Valera","5621254",false);

var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);


//Personas activas
var busqueda = personas.Where(x => x.Estado == true).ToList();

//Busqueda por DNI
var busquedaDNI = personas.Where(z => z.Dni == 20404870).FirstOrDefault();

var busquedaLINQ = (from p in personas
                    where p.Dni == 20404870
                    select p).FirstOrDefault();