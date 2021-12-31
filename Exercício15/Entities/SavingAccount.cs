
namespace Exercício15.Entities
{
    class SavingsAccount : Account //Herança
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) //Aproveitando construtor da Superclasse
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; //Atualiza o saldo com a taxa de juros 
        }
    }
}
