using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Ronald_Morales
{
    internal class Program
    {
        static void Main()
        {
            //EJERCICIO 1

            Console.WriteLine("---Panel de Acceso Numérico---");
            Console.WriteLine();

            bool idCorrecto = false;
            bool pinCorrecto = false;
            bool tokenCorrecto = false;

            Console.WriteLine("Ingresa tu ID: ");
            int IdUsuario = int.Parse(Console.ReadLine());

            if (IdUsuario == 2026)
            {
                Console.WriteLine("Usuario reconocido.");
                idCorrecto = true;
            }
            else
            {
                Console.WriteLine("Usuario no reconocido.");
            }

            Console.WriteLine();
            Console.WriteLine("ingresa tu PIN: ");
            int PinUsuario = int.Parse(Console.ReadLine());

            if (PinUsuario == 1234)
            {
                Console.WriteLine("PIN correcto.");
                pinCorrecto = true;
            }
            else
            {
                Console.WriteLine("PIN incorrecto.");
            }

            Console.WriteLine();
            Console.WriteLine("Token de seguridad: ");
            int TokenSeguridad = int.Parse(Console.ReadLine());

            if (TokenSeguridad == 777)
            {
                Console.WriteLine("Token válido.");
                tokenCorrecto = true;
            }
            else
            {
                Console.WriteLine("Token inválido.");
            }

            Console.WriteLine();
            Console.WriteLine("Quieres activar el modo serguro? (si[1]/no[0]): ");
            int ModoSeguro = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ModoSeguro == 1)
            {
                Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado.");
            }

            if (idCorrecto && pinCorrecto && tokenCorrecto)
            {
                Console.WriteLine("Acceso total concedido.");
            }
            else
            {
                Console.WriteLine("Acceso denegado.");
            }

            if (ModoSeguro == 1)
            {
                if (TokenSeguridad >= 700)
                {
                    Console.WriteLine("Regla extra aprobada.");
                }
                else
                {
                    Console.WriteLine("Regla extra fallida.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            //EJERCICIO 2

            Console.WriteLine("---Validador de PIN Inteligente---");

            Console.Write("Ingrese PIN: ");
            int pin = int.Parse(Console.ReadLine());

            bool cuatroDigitos = false;
            bool esPar = false;
            bool multiplo5 = false;

            if (pin >= 1000 && pin <= 9999)
            {
                Console.WriteLine("PIN de 4 dígitos: OK.");
                cuatroDigitos = true;
            }
            else
            {
                Console.WriteLine("PIN inválido: debe tener 4 dígitos.");
            }

            if (pin % 2 == 0)
            {
                Console.WriteLine("PIN par.");
                esPar = true;
            }
            else
            {
                Console.WriteLine("PIN impar.");
            }

            if (pin % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5.");
                multiplo5 = true;
            }
            else
            {
                Console.WriteLine("No es múltiplo de 5.");
            }

            if (cuatroDigitos && esPar && multiplo5)
            {
                Console.WriteLine("PIN aceptado por política.");
            }
            else
            {
                Console.WriteLine("PIN rechazado por política.");
            }


            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            //EJERCICIO 3  

            Console.WriteLine("---Activación de Cuenta---");

            Console.Write("Código de activación: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("¿Aceptó términos? (si[1]/no[0]): ");
            int terminos = int.Parse(Console.ReadLine());

            Console.Write("¿Activó 2FA? (si[1]/no[0]): ");
            int dosFA = int.Parse(Console.ReadLine());

            Console.Write("Puntaje (0-100): ");
            int puntaje = int.Parse(Console.ReadLine());

            Console.WriteLine();

            bool codigoCorrecto = false;
            bool edadValida = false;
            bool terminosAceptados = false;
            bool faActivado = false;
            bool puntajeValido = false;

            if (codigo == 2026)
            {
                Console.WriteLine("Código correcto.");
                codigoCorrecto = true;
            }
            else
            {
                Console.WriteLine("Código incorrecto.");
            }

            if (edad >= 18)
            {
                Console.WriteLine("Edad válida.");
                edadValida = true;
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }

            if (terminos == 1)
            {
                Console.WriteLine("Términos aceptados.");
                terminosAceptados = true;
            }
            else
            {
                Console.WriteLine("Debe aceptar términos.");
            }

            if (dosFA == 1)
            {
                Console.WriteLine("2FA activado.");
                faActivado = true;
            }
            else
            {
                Console.WriteLine("2FA no activado.");
            }

            if (puntaje >= 70)
            {
                Console.WriteLine("Puntaje suficiente.");
                puntajeValido = true;
            }
            else
            {
                Console.WriteLine("Puntaje insuficiente.");
            }

            Console.WriteLine();

            if (codigoCorrecto && edadValida && terminosAceptados && faActivado && puntajeValido)
            {
                Console.WriteLine("Cuenta activada exitosamente.");
            }
            else
            {
                Console.WriteLine("Cuenta NO activada.");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            //EJERCICIO 4

            Console.WriteLine("---Acceso a Sala de Examen---");

            Console.Write("Nota previa: ");
            int nota = int.Parse(Console.ReadLine());

            Console.Write("Minutos de llegada tarde: ");
            int tarde = int.Parse(Console.ReadLine());

            Console.Write("¿Tiene solvencia? (si[1]/no[0]): ");
            int solvencia = int.Parse(Console.ReadLine());

            Console.Write("¿Trae identificación? (si[1]/no[0]): ");
            int identificacion = int.Parse(Console.ReadLine());

            Console.Write("¿Trae calculadora permitida? (si[1]/no[0]): ");
            int calculadora = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (nota >= 61)
            {
                Console.WriteLine("Requisito académico aprobado.");
            }
            else
            {
                Console.WriteLine("Requisito académico NO aprobado.");
            }
            if (tarde <= 10)
            { 
                Console.WriteLine("Hora válida."); 
            }
            else
            {
                Console.WriteLine("Llegada tarde: fuera de tiempo."); 
            }

            if (solvencia == 1)
            {
                Console.WriteLine("Solvencia validada.");
            }
            else
            {   
                Console.WriteLine("Sin solvencia.");
            }

            if (identificacion == 1)
            { 
                Console.WriteLine("Identificación validada."); 
            }
            else
            { 
                Console.WriteLine("Sin identificación.");
            }

            if (calculadora == 1)
            { 
                Console.WriteLine("Calculadora permitida: OK.");
            }
            else
            { 
                Console.WriteLine("Sin calculadora permitida.");
            }

            if (nota >= 61 && tarde <= 10 && solvencia == 1 && identificacion == 1)
            { 
                Console.WriteLine("Acceso a sala de examen concedido.");
            }
            else
            {
                Console.WriteLine("Acceso denegado.");
            }

            if (tarde > 0 && tarde <= 10)
            { 
                Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            //BONUS

            Console.WriteLine("---San Valentín Hacker Edition---");

            Console.Write("Nombre de la persona: ");
            string nombre = Console.ReadLine();

            Console.Write("Nivel de valentía (0-100): ");
            int valentia = int.Parse(Console.ReadLine());

            Console.Write("¿Le gusta la programación? (si[1]/no[0]): ");
            int programacion = int.Parse(Console.ReadLine());

            Console.Write("¿Le gustan los memes técnicos? (si[1]/no[0]): ");
            int memes = int.Parse(Console.ReadLine());

            Console.Write("Nivel de interés (0-100): ");
            int interes = int.Parse(Console.ReadLine());

            Console.Write("¿Está soltera/o? (si[1]/no[0]): ");
            int soltero = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (interes >= 70)
            { 
                Console.WriteLine("Interés alto detectado."); 
            }
            else
            { 
                Console.WriteLine("Interés insuficiente. Riesgo de friend zone elevado."); 
            }

            if (valentia >= 70)
            { 
                Console.WriteLine("Valentía favorable. Confía en sí mismo(a)."); 
            }
            else
            { 
                Console.WriteLine("Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym)."); 
            }

            if (soltero == 1)
            {
                Console.WriteLine("Estado sentimental favorable… aunque lo esté, no le crea: todos/todas mienten."); 
            }
            else
            {
                Console.WriteLine("Estado sentimental comprometido, no es recomendable hackear esa relación."); 
            }

            if (programacion == 1 && memes == 1)
            {
                Console.WriteLine("Compatibilidad geek detectada."); 
            }
            else
            {
                Console.WriteLine("Compatibilidad parcial o inexistente."); 
            }

            if (interes >= 70 && soltero == 1 && programacion == 1 && memes == 1 && valentia >= 70)
            {
                Console.WriteLine("DECLARACIÓN APROBADA. Proceder con chocolates y flores.");
            }
            else if (interes >= 70 && soltero == 1 && programacion == 1 && memes == 1 && valentia < 70)
            {
                Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1.");
            }
            else
            {
                Console.WriteLine(nombre + ", no te ama.. por ahora.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Saludos...");
            Console.WriteLine("────────█████─────────────█████");
            Console.WriteLine("────████████████───────████████████");
            Console.WriteLine("──████▓▓▓▓▓▓▓▓▓▓██───███▓▓▓▓▓▓▓▓▓████");
            Console.WriteLine("─███▓▓▓▓▓▓▓▓▓▓▓▓▓██─██▓▓▓▓▓▓▓▓▓▓▓▓▓███");
            Console.WriteLine("███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███");
            Console.WriteLine("██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██");
            Console.WriteLine("██▓▓▓▓▓▓▓▓▓──────────────────▓▓▓▓▓▓▓▓██");
            Console.WriteLine("██▓▓▓▓▓▓▓─██───████─█──█─█████─▓▓▓▓▓▓██");
            Console.WriteLine("██▓▓▓▓▓▓▓─██───█──█─█──█─██────▓▓▓▓▓▓██");
            Console.WriteLine("███▓▓▓▓▓▓─██───█──█─█──█─█████─▓▓▓▓▓▓██");
            Console.WriteLine("███▓▓▓▓▓▓─██───█──█─█──█─██────▓▓▓▓▓▓██");
            Console.WriteLine("─███▓▓▓▓▓─████─████─████─█████─▓▓▓▓███");
            Console.WriteLine("───███▓▓▓▓▓──────────────────▓▓▓▓▓▓███");
            Console.WriteLine("────████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████");
            Console.WriteLine("─────████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████");
            Console.WriteLine("───────████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█████");
            Console.WriteLine("──────────████▓▓▓▓▓▓▓▓▓▓▓▓████");
            Console.WriteLine("─────────────███▓▓▓▓▓▓▓████");
            Console.WriteLine("───────────────███▓▓▓███");
            Console.WriteLine("─────────────────██▓██");
            Console.WriteLine("──────────────────███");
        }
    }
}
