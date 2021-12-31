using System;
using Exercício15.Entities;
namespace Exercício15
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(8010, "Jéssica", 100.0, 500.5); //Instanciando um objeto e passando parâmetros

            //Upcasting

            Account acc1 = bacc; //Fazendo uma Superclasse receber uma subclasse, como a herança entre classes
                                 //é do tipo "é um" significa que isso é permitido porque a subclasse É UMA classe

            Account acc2 = new BusinessAccount(1002, "Jéssica", 100, 400); //Fazendo uma Superclasse receber uma subclasse 
                                                                           //através de instanciação, ou sejá, está sendo instanciado uma subclasse

            Account acc3 = new SavingsAccount(1003, "Ana", 0.0, 0.01); //Fazendo uma Superclasse receber uma subclasse 
                                                                       //através de instanciação, ou sejá, está sendo instanciado uma subclasse


            //Downcasting 

            BusinessAccount bacc1 = (BusinessAccount)acc2; //Para converter um objeto do tipo Superclasse para uma classe é necessário utilizar o casting

            BusinessAccount acc4 = (BusinessAccount)acc3; //Em tempo de execução vai apresentar erro
                                                          //porque na linha 20 acc3 foi convertido através de Upcasting para uma subclasse 
                                                          //o que torna o downcasting na linha 28 redundante ocorrendo erro System.InvalidCastException

            if (acc3 is BusinessAccount) //Para não ocorrer o erro acima pode ser testado dessa forma
            {
                BusinessAccount acc6 = (BusinessAccount)acc3;
            }

            BusinessAccount aac6 = acc3 as BusinessAccount; //Sintaxe alternativa
        }
    }
}

