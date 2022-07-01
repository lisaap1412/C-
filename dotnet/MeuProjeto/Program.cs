using System;

namespace MeuProjeto // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
         ContaCorrente conta_da_Buru = new ContaCorrente ("Barbara",13445,2325,54);
         ContaCorrente conta_da_Ny = new ContaCorrente ("Nyvi",134,235,556);
         ContaCorrente conta_da_Vi = new ContaCorrente ("Viviane",1543,547,763);

         Console.WriteLine(" A conta é da " + conta_da_Buru.Titular + ", o numero da agência é " + conta_da_Buru.Agencia + " e o numero da conta é " + conta_da_Buru.Numero + ".");
         Console.WriteLine(" A conta é da " + conta_da_Ny.Titular + ", o numero da agência é " + conta_da_Ny.Agencia + " e o numero da conta é " + conta_da_Ny.Numero + ".");
         Console.WriteLine(" A conta é da " + conta_da_Vi.Titular + ", o numero da agência é " + conta_da_Vi.Agencia + " e o numero da conta é " + conta_da_Vi.Numero + ".");

        }   
    }
}