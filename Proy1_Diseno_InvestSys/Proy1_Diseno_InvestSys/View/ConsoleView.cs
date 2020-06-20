using Proy1_Diseno_InvestSys.Controller;
using System;

namespace ConsoleView
{
    class ConsoleView
    {
        static void Main(string[] args)
        {
            string name;
            string investmentSys;
            float ammount;
            int days;
            float annualRate = 0;

            Console.WriteLine("Bienvenido al sistema de registro de datos para comenzar su cuenta de inversión.");
            Console.WriteLine("Seleccione el tipo de inversión que desea realizar (1, 2 o 3):\n1.Cuenta Corriente (Solo colones).\n2.Inversión a la vista tasa pactada (Solo colones o dólares).\n3.Certificado de depósito a plazo (Solo colones).");
            String numInversion = Console.ReadLine();
            while (numInversion != "1" && numInversion != "2" && numInversion != "3")
            {
                Console.WriteLine("\nPorfavor ingrese un número válido (1, 2 o 3):\n1.Cuenta Corriente (Solo colones).\n2.Inversión a la vista tasa pactada (Solo colones o dólares).\n3.Certificado de depósito a plazo (Solo colones).");
                numInversion = Console.ReadLine();
            }
            if (numInversion == "1")
            {
                Console.Clear();
                investmentSys = "Cuenta Corriente";
                Console.WriteLine("Se seleccionó la opción de Cuenta Corriente.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Esta cuenta es solo de COLONES.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese los siguientes datos.\nNombre: ");
                name = Console.ReadLine();
                Console.Write("Plazo de inversión en días (Debe ser un número entero, mayor a 0): ");
                days = proveDays(1);
                Console.Write("Monto a invertir en Colones (Debe ser un número, puede contener decimales y mayor o igual a 25000): ");
                ammount = proveAmmount(25000);
                //Obtener el interes anual segun datos actuales
                annualRate = annualRate * 100;
                Console.WriteLine("Datos ingresados:\nCliente: " + name + "\nMonto de ahorro e inversión: " + ammount + "\nPlazo de la inversión días: " + days + "\nSistema de ahorro e inversión: " + investmentSys + "\nInterés anual correspondiente: \n");

            }

            else if (numInversion == "2")
            {
                Console.Clear();
                string numCurrency;
                investmentSys = "Inversión a la vista tasa pactada";
                Console.WriteLine("Se seleccionó la opción de Inversión a la vista tasa pactada.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Esta cuenta es solo de COLONES o DOLÁRES.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Seleccione el tipo de moneda de inversión continuar el registro en 1.Colones o en 2.Doláres: ");
                numCurrency = Console.ReadLine();
                while (numCurrency != "1" && numCurrency != "2")
                {
                    Console.Write("\nPorfavor ingrese un número válido para el tipo de moneda de inversión (1 o 2): 1.Colones o 2.Doláres: ");
                    numCurrency = Console.ReadLine();
                }
                if (numCurrency == "1") {
                    Console.Read();
                    Console.Write("Ingrese los siguientes datos:\nNombre: ");
                    name = Console.ReadLine();
                    Console.Write("Plazo de inversión en días (Debe ser un número entero, mayor o igual a 15): ");
                    days = proveDays(15);
                    Console.Write("Monto a invertir en Colones (Debe ser un número, puede contener decimales y mayor o igual a 100000): ");
                    ammount = proveAmmount(100000);
                    annualRate = annualRate * 100;
                    Console.WriteLine("Datos ingresados:\nCliente: " + name + "\nMonto de ahorro e inversión: " + ammount + "\nPlazo de la inversión días: " + days + "\nSistema de ahorro e inversión: " + investmentSys + "\nInterés anual correspondiente: \n");

                }
                else if (numCurrency == "2")
                {
                    Console.Read();
                    Console.Write("Ingrese los siguientes datos:\nNombre: ");
                    name = Console.ReadLine();
                    Console.Write("Plazo de inversión en días (Debe ser un número entero, mayor o igual a 15 días): ");
                    days = proveDays(15);
                    Console.Write("Monto a invertir en Dolares (Debe ser un número, puede contener decimales y mayor o igual a 500): ");
                    ammount = proveAmmount(500);
                    annualRate = annualRate * 100;
                    Console.WriteLine("Datos ingresados:\nCliente: " + name + "\nMonto de ahorro e inversión: " + ammount + "\nPlazo de la inversión días: " + days + "\nSistema de ahorro e inversión: " + investmentSys + "\nInterés anual correspondiente: "+annualRate+"\n");

                }
            }
            else if (numInversion == "3")
            {
                Console.Clear();
                investmentSys = "Certificado de inversión";
                Console.WriteLine("Se seleccionó la opción de Certificado de depósito a plazo.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Esta cuenta es solo de COLONES.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese los siguientes datos:\nNombre: ");
                name = Console.ReadLine();
                Console.Write("Plazo de inversión en días (Debe ser un número, mayor a 30): ");
                days = proveDays(30);
                Console.Write("Monto a invertir en Colones (Debe ser un número, puede contener decimales y mayor o igual a ): ");
                ammount = proveAmmountTermDeposit(days);
                annualRate = annualRate * 100;
                Console.WriteLine("Datos ingresados:\nCliente: " + name + "\nMonto de ahorro e inversión: " + ammount + "\nPlazo de la inversión días: " + days + "\nSistema de ahorro e inversión: " + investmentSys + "\nInterés anual correspondiente: "+annualRate + "\n");
            }
            

            Console.Write("¿Desea registrar otra cuenta de inversión? Escriba: Si o No.\n");
            String reDo = Console.ReadLine().ToLower();
            while(reDo != "si" && reDo != "no")
            {
                Console.WriteLine("Porfavor ingresar una respuesta válida: Si o No.");
                reDo = Console.ReadLine();
            }
            if (reDo == "si")
            {
                Console.Clear();
                Main(null);
            }
            else
            {
                Console.Clear();
                Console.Write("¡Gracias por utilizar nuestra aplicación!\nPresione cualquier tecla para cerrar la aplicación de consola de Cuentas de inversión.");
                Console.ReadKey();
            }



            //Funciones para probar si los datos cumplen los requisitos
            //Probar monto de inversion de Corriente y Plazo pactado y si es un float
            float proveAmmount(float minAmmount)
            {
                float retAmmount;
                while (!float.TryParse(Console.ReadLine(), out retAmmount))
                {
                    Console.WriteLine("\nMonto a invertir no válido.");
                    Console.Write("Monto a invertir (Debe ser un número, puede contener decimales): ");

                }
                if (retAmmount < minAmmount)
                {
                    Console.WriteLine("\nMonto a invertir menor a" + minAmmount + ". Porfavor ingrese un monto mayor.");
                    Console.Write("Monto a invertir (Debe ser un número, puede contener decimales): ");
                    return proveAmmount(minAmmount);
                }
                return retAmmount;
            }

            //Probar monto de inversion de deposito a plazo y es un float
            float proveAmmountTermDeposit(int numDays)
            {
                float retAmmount;
                while (!float.TryParse(Console.ReadLine(), out retAmmount))
                {
                    Console.WriteLine("\nMonto a invertir no válido.");
                    Console.Write("Monto a invertir (Debe ser un número, puede contener decimales): ");

                }
                if (numDays >= 30 && numDays <= 89)
                {
                    if (retAmmount < 100000)
                    {
                        Console.WriteLine("\nMonto a invertir menor a 100000. Porfavor ingrese un monto mayor.");
                        Console.Write("Monto a invertir (Debe ser un número, puede contener decimales): ");
                        return proveAmmountTermDeposit(numDays);
                    }
                }
                else if (numDays >= 90)
                {
                    if (retAmmount < 50000)
                    {
                        Console.WriteLine("\nMonto a invertir menor a 50000. Porfavor ingrese un monto mayor.");
                        Console.Write("Monto a invertir (Debe ser un número, puede contener decimales): ");
                        return proveAmmountTermDeposit(numDays);
                    }
                }
                return retAmmount;
            }

            //Probar si el plazo de tiempo es mayor al mínimo y es un int
            int proveDays(int minDays)
            {
                int retDays;
                while (!int.TryParse(Console.ReadLine(), out retDays))
                {
                    Console.WriteLine("\nPlazo de inversión no válido.");
                    Console.Write("Plazo de inversión en días (Debe ser un número, mayor a "+ minDays +"): ");
                }
                if (retDays < minDays)
                {
                    Console.WriteLine("\nPlazo de inversión menor a" + minDays + ". Porfavor ingrese un plazo mayor.");
                    Console.Write("Plazo de inversión en días (Debe ser un número, mayor a " + minDays + "): ");
                    return proveDays(minDays);
                }
                return retDays;
            }



        }
        
    }
}
