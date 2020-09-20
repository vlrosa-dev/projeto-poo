using System;
using projeto_poo.entidades.home;

namespace projeto_poo.entidades
{
    class Program
    {
        static void Main(string[] args)
        {

            int operacao;            

            ReadConsole read = new ReadConsole();
            InterfaceConsole interfaceConsole = new InterfaceConsole(); 

            operacao = read.MenuHome();              

            while (operacao != 0)
            {       
                switch (operacao)
                {
                    case 1:
                        interfaceConsole.CreateProduct();
                        break;
                    
                    case 2:
                        interfaceConsole.CreateOrder();
                        break;
                }

                operacao = read.MenuHome(); 
            
            }
  
        }
    }
}
