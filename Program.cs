using System.ComponentModel.Design;

List<int> Numbers = new List<int>();
decimal result = 0;
//Dioris Isaac Peña Mateo #20260924

bool ON = true;
try
{
    while (ON)
    {
        Console.WriteLine("Bienvenido a la mejor calculadora del mundo");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Calcular promedio");
        Console.WriteLine("6. Salir");

        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Numbers.Clear(); 
                Console.WriteLine("Elegiste la suma");

                Console.WriteLine("Ingresa el primer número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa el segundo número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Quieres calcular otro numero 1.SI 2.NO");
                int AnotherNumber = Convert.ToInt32(Console.ReadLine());

                while (AnotherNumber == 1)
                {
                    Console.WriteLine("Añada el numero");
                    Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Quieres Continuar? 1.Si 2.No");
                    AnotherNumber = (Convert.ToInt32(Console.ReadLine()));
                }
                result = Numbers[0];
                for (int i = 1; i < Numbers.Count; i++)
                {

                    result += Numbers[i];
                }

                break;

            case 2:
                Numbers.Clear();
                Console.WriteLine("Elegiste la resta");

                Console.WriteLine("Ingresa el primer número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa el segundo número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Quieres calcular otro numero 1.SI 2.NO");
                AnotherNumber = Convert.ToInt32(Console.ReadLine());
                while (AnotherNumber == 1)
                {
                    Console.WriteLine("Añada el numero");
                    Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Quieres Continuar? 1.Si 2.No");
                    AnotherNumber = (Convert.ToInt32(Console.ReadLine()));
                }
                result = Numbers[0];
                for (int i = 1; i < Numbers.Count; i++)
                {

                    result -= Numbers[i];
                }

                break;


            case 3:
                Numbers.Clear();
                Console.WriteLine("Elegiste multiplicar");

                Console.WriteLine("Ingresa el primer número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa el segundo número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));
                result = Numbers[0];

                Console.WriteLine("Quieres calcular otro numero 1.SI 2.NO");
                AnotherNumber = Convert.ToInt32(Console.ReadLine());
                while (AnotherNumber == 1)
                {
                    Console.WriteLine("Añada el numero");
                    Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Quieres Continuar? 1.Si 2.No");
                    AnotherNumber = (Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 1; i < Numbers.Count; i++)
                {

                    result *= Numbers[i];
                }

                break;


            case 4:
                Numbers.Clear();
                Console.WriteLine("Elegiste dividir");

                Console.WriteLine("Ingresa el primer número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa el segundo número:");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));
                result = Numbers[0];

                Console.WriteLine("Quieres calcular otro numero 1.SI 2.NO");
                AnotherNumber = Convert.ToInt32(Console.ReadLine());
                while (AnotherNumber == 1)
                {
                    Console.WriteLine("Añada el numero");
                    Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Quieres Continuar? 1.Si 2.No");
                    AnotherNumber = (Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 1; i < Numbers.Count; i++)
                {

                    result /= Numbers[i];
                }
                break;


            case 5:
                Numbers.Clear();
                Console.WriteLine("Elegiste calcular promedio");

                Console.WriteLine("Ingresa tu primera nota");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa tu segunda nota");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa tu tecera nota");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Ingresa tu cuarta nota");
                Numbers.Add(Convert.ToInt32(Console.ReadLine()));

                result = Numbers[0];
                for (int i = 1; i < Numbers.Count; i++)
                {

                    result += Numbers[i];
                }
                result = result / 4;

                if (result >= 90)
                {
                    Console.WriteLine("Felicidades eres una maquina aprobaste ");
                }
                else if (result >= 70 )
                {
                    Console.WriteLine("Felicidades ");
                }
                else
                {
                    Console.WriteLine("Manito te quemaste");
                }

                break;

            case 6:
                Numbers.Clear();
                Console.WriteLine("Saliendo...");
                ON = false;
                break;

            default:
                Console.WriteLine("Opción inválida");
                result = 0;
                break;

        }
        Console.WriteLine($"Tu resultado es {result}");

    }
}
catch (Exception ex)
{
    Console.WriteLine("Eso no es una Opcion valida ");
}
finally
{
    Console.WriteLine("GRACIAS POR USAR LA MEJOR CALCULADORA");

}








