using System;

class Program
{
    static void Main()
    {

        string usuarioValido = "usuario123";
        string contraseñaValida = "ContraseñaSegura";


        Console.Write("Ingrese su nombre de usuario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contraseñaIngresada = Console.ReadLine();


        if (usuarioIngresado != usuarioValido)
        {
            Console.WriteLine("Usuario no registrado.");
        }
        else if (contraseñaIngresada == contraseñaValida)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
        }
    }
}
