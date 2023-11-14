using HerancaEPolimorfismo.Entities;
namespace HerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "douglas", 0);
            BussinesAccount bacc1 = new BussinesAccount(1101, "Maria", 0, 500);

            // também pode chamar a superclasse e instanciar um objeto da subclasse

            Account acc2 = new BussinesAccount(1002, "Douglas", 0, 500);

            Account acc3 = new SavingsAccount(0.1, 1003, "Douglitos", 500);


            // UPCASTING
            // BussinessAccoun é um Account

            acc1 = bacc1;

            // DOWNCASTING
            // Preciso converter explicitamente para uma subclasse

            BussinesAccount acc4 = (BussinesAccount)acc1;

            acc4.loan(200);

            // O compilador não identifica inconsistência de downcasting

            // portanto não é possível fazer: BussinesAccount acc5 = (BussinesAccount)acc3;
            // utilizaremos "is":

            if (acc3 is BussinesAccount)
            {
                BussinesAccount acc5 = (BussinesAccount)acc3;
            }

        }
    }
}