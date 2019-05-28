using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionFinal
{
    class Billetera
    {
        double valorinicial;
        int gastado;
        double banco;
        double ahorro;
        double totalahorro;
        int elegir;

        public double Valorinicial
        {
            get { return valorinicial; }
            set { valorinicial = value; }
        }
        public double Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        public double Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }
        public double TotalAhorro
        {
            get { return totalahorro; }
            set { totalahorro = value; }
        }
        public int Gastado
        {
            get { return gastado; }
            set { gastado = value; }
        }
        public int Elegir
        {
            get { return elegir; }
            set { elegir = value; }
        }
        public void IngresarDinero()
        {
            Console.WriteLine("Ingresar el valor de la cantidad de dinero: ");
            Valorinicial = int.Parse(Console.ReadLine());
            Console.WriteLine($"El valor ingresado es: ${Valorinicial}");
        }
        public void Gastar()
        {
            Console.WriteLine("Ingresar el valor de la cantidad a gastar: ");
            Gastado = int.Parse(Console.ReadLine());
            if (Gastado > Valorinicial)
            {
                Console.WriteLine("No tiene suficiente dinero");
                Console.WriteLine($"El dinero que actualmente tiene es: ${Valorinicial}");
            }
            else
            {
                Valorinicial = Valorinicial - Gastado;
                Ahorro = (Gastado * 10) / 100;
                Valorinicial = Valorinicial - Ahorro;
                TotalAhorro = TotalAhorro + Ahorro;
                Console.WriteLine($"Por este gasto ahorró : ${Ahorro}");
                Console.WriteLine($"Le quedan  : ${Valorinicial}");
            }
        }
        public void Depositar()
        {
            if (Valorinicial > 0)
            {
                Banco = Banco + Valorinicial;
                Valorinicial = 0;
                Console.WriteLine($"En su cuenta bancaria se deposito: ${Banco}");
                Console.WriteLine($"En su billetera tiene : $0");
                Console.WriteLine($"En su billetera tiene ahorrado : ${TotalAhorro}");
            }
            else
            {
                Console.WriteLine("No tienes dinero!!");
            }
        }
        public void ImprimirDinero()
        {
            Console.WriteLine("En la billetera tiene esta cantidad de dinero: " + Valorinicial);
        }

        public void TotalAhorrado()
        {
            Console.WriteLine($"El dinero ahorrado en el banco es de: ${Banco}");
        }
        public void NotificarTransaccion()
        {
            if (Elegir == 0)
            {
                Console.WriteLine("******************");
                Console.WriteLine("***NOTIFICACIÓN***");
                Console.WriteLine("******************");
                Console.WriteLine($"Se ingresó la siguiente cantidad: ${Valorinicial}");
            }
            else if (Elegir == 1)
            {
                Console.WriteLine("******************");
                Console.WriteLine("***NOTIFICACIÓN***");
                Console.WriteLine("******************");
                Console.WriteLine($"Se gasto el siguiente dinero: ${Gastado}");
            }
            else if (Elegir == 2)
            {
                Console.WriteLine("******************");
                Console.WriteLine("***NOTIFICACIÓN***");
                Console.WriteLine("******************");
                Console.WriteLine($"En el banco tiene la siguinete cantidad de dinero: ${Banco}");
            }
            else if (Elegir == 3)
            {
                Console.WriteLine("******************");
                Console.WriteLine("***NOTIFICACIÓN***");
                Console.WriteLine("******************"); ;
                Console.WriteLine($"Cuenta con el siguiente dinero en la billetera: ${Valorinicial}");
            }
            else if (Elegir == 4)
            {
                Console.WriteLine("******************");
                Console.WriteLine("***NOTIFICACIÓN***");
                Console.WriteLine("******************");
            }
        }
        public void MenuInicial()
        {
            Console.WriteLine("********Seleccione********");
            Console.WriteLine("0- Ingresar cantidad de dinero inicial");
            Console.WriteLine("1- Ingresar cantidad de dinero a gastar");
            Console.WriteLine("2- Transferir cantidad de dinero de la billetera al banco");
            Console.WriteLine("3- Consultar cantidad de dinero que hay en la billetera");
            Console.WriteLine("4- Consultar ahorro en el banco");
            Elegir = Convert.ToInt32(Console.ReadLine());
            if (Elegir < 0 || Elegir > 4)
            {
                Console.WriteLine("Ingrese una opcion valida en el rango de: (0-4)");
            }
            switch (Elegir)
            {
                case 0:
                    IngresarDinero();
                    NotificarTransaccion();
                    MenuInicial();
                    break;
                case 1:
                    Gastar();
                    NotificarTransaccion();
                    MenuInicial();
                    break;
                case 2:
                    if (Valorinicial > 0)
                    {
                        Depositar();
                        NotificarTransaccion();
                        MenuInicial();
                    }
                    else
                    {
                        Console.WriteLine("No tiene dinero");
                        MenuInicial();
                    }
                    break;
                case 3:
                    ImprimirDinero();
                    NotificarTransaccion();
                    MenuInicial();
                    break;
                case 4:
                    TotalAhorrado();
                    NotificarTransaccion();
                    MenuInicial();
                    break;
            }
        }
    }
}
        