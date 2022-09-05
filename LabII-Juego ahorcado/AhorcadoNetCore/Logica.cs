using System;
using System.Linq;

namespace AhorcadoNetCore
{
    public static class Logica
    {

        public static string[] arrayPalabras = new string[15];
        static int vidas;
       public static void CargarPalabras()
        {
            arrayPalabras[0] = "PERRO";
            arrayPalabras[1] = "GATO";
            arrayPalabras[2] = "CABALLO";
            arrayPalabras[3] = "VACACIONES";
            arrayPalabras[4] = "APROBAR";
            arrayPalabras[5] = "GUITARRA";
            arrayPalabras[6] = "ESTUDIAR";
            arrayPalabras[7] = "ANIVERSARIO";
            arrayPalabras[8] = "COMPUTADORA";
        }


        public static void AgregarPalabraNueva(string datoIngresado)
        {
            int indice;

            indice = Funciones.RetornarIndiceEspacioDisponible(arrayPalabras);
            if (indice != -1)
            {
                arrayPalabras[indice] = datoIngresado;
                Console.WriteLine("Nueva palabra agregada");
                Funciones.PresioneUnaTeclaParaContinuar();
            }
        }


        public static bool ComenzarJuego()
        {
            Console.Clear();
            #region Variables
            vidas = 5;
            string palabraSecreta = Funciones.RetornarPalabraRandom(arrayPalabras);
            int recuento = -1;
            char[] arrayLetrasPalabraSecreta = palabraSecreta.ToCharArray();
            char[] mostrarArrayProgreso = new char[palabraSecreta.Length];
            char[] letrasArriesgadas = new char[26];
            int indiceLetrasArriesgadas = 0;
            bool victoria = false;
            char letraArriesgada;
            #endregion

            foreach (char letra in mostrarArrayProgreso)
            {
                recuento++;
                mostrarArrayProgreso[recuento] = '-';
            }

            while (vidas > 0)
            {
                recuento = -1;
                string mostrarProgreso = String.Concat(mostrarArrayProgreso);
                bool letraEncontrada = false;
                int multiples = 0;

                if (mostrarProgreso == palabraSecreta)
                {
                    victoria = true;
                    break;
                }
                if (vidas > 1)
                {
                    Console.WriteLine("Tienes {0} vidas!!", vidas);
                }
                else
                {
                    Console.WriteLine("Te quedan solo {0} vidas!!", vidas);
                }
                Console.Write("\n");
                Console.WriteLine("Estado actual: " + mostrarProgreso);
                Console.Write("\n\n\n");
                Console.Write("Ingresa una letra: ");

                letraArriesgada = Convert.ToChar(Funciones.IngresarLetra());

                Console.Clear();

                if (letrasArriesgadas.Contains(letraArriesgada) == false)
                {

                    letrasArriesgadas[indiceLetrasArriesgadas] = letraArriesgada;
                    indiceLetrasArriesgadas++;

                    foreach (char letter in arrayLetrasPalabraSecreta)
                    {
                        recuento++;
                        if (letter == letraArriesgada)
                        {
                            mostrarArrayProgreso[recuento] = letraArriesgada;
                            letraEncontrada = true;
                            multiples++;
                        }
                    }

                    if (letraEncontrada)
                    {
                        Console.WriteLine("Encontrada {0} veces la letra {1}!", multiples, letraArriesgada);
                    }
                    else
                    {
                        Console.WriteLine("mmm frio frio... {0}!", letraArriesgada);
                        vidas--;
                    }

                }
                else
                {
                    Console.WriteLine("Ya adivinaste la letra {0}!!", letraArriesgada);
                }

                Logica.DibujarPersonaje(vidas);

            }

            Console.WriteLine("\n\nLa palabra era: {0}", palabraSecreta);
            if (victoria)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nGANASTEEEEE!!!! LA TENES RE CLARA!!!!!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n AH NOOO, RE LOOOSER!! A CASAA!!!!!!!!!!!");
            }
            Console.ResetColor();
            return Funciones.SeguirEn("Jugando");

        }

        public static void DibujarPersonaje(int vidasRestantes)
        {
            ConsoleColor aux = ConsoleColor.White;
            string dibujo = "";

            if (vidasRestantes < 5)
            {
                dibujo += "--------\n";
                aux = ConsoleColor.Green;
            }

            if (vidasRestantes < 4)
            {
                dibujo += "       |\n";
                aux = ConsoleColor.Yellow;
            }

            if (vidasRestantes < 3)
            {
                dibujo += "       O\n";
                aux = ConsoleColor.Yellow;
            }

            if (vidasRestantes < 2)
            {
                dibujo += "      /|\\ \n";
                aux = ConsoleColor.Red;
            }

            if (vidasRestantes == 0)
            {
                dibujo += "      / \\ \n";
                aux = ConsoleColor.Red;
            }

            Console.ForegroundColor = aux;
            Console.WriteLine(dibujo);
            Console.ResetColor();
        }

        public static string IngresarPalabraNueva()
        {
            Console.WriteLine("\nIngrese nueva palabra");
            string nuevaPalabra = Console.ReadLine();

            while (!Funciones.ValidarSiPalabraEsValida(nuevaPalabra))
            {
                Console.WriteLine("La palabra debe contener SOLO letras");
                nuevaPalabra = Console.ReadLine();
            }

            return nuevaPalabra.ToUpper();
        }


        public static void MostrarPalabras()
        {
            Menu.DibujarEncabezado("Palabras cargadas actualmente");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < arrayPalabras.Length; i++)
            {
                if (string.IsNullOrEmpty(arrayPalabras[i]))
                {
                    break;
                } 

                Console.WriteLine($"{i}. {arrayPalabras[i]}");
            }
        }

        public static void EliminarPalabra()
        {
            int max = arrayPalabras.Length - 1;
            Console.Write("Ingresa el indice de la palabra a eliminar: ");

            int indiceDePalabraABorrar = Funciones.ValidarEntero(0, max);
            string palabraBorrada = arrayPalabras[indiceDePalabraABorrar];

            arrayPalabras = arrayPalabras.Where((palabra, indice) => indice != indiceDePalabraABorrar).ToArray();

            Console.WriteLine($"La palabra {palabraBorrada} fue borrada exitosamente");
            Funciones.PresioneUnaTeclaParaContinuar();
        }
    }
}
