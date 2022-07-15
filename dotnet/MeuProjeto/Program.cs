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

         Console.WriteLine(" A conta é da " + conta_da_Buru.Titular + ", o numero da agência é " + conta_da_Buru.Agencia + " e o numero da conta é " + conta_da_Buru.Numero + " Saldo: " + conta_da_Buru.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Ny.Titular + ", o numero da agência é " + conta_da_Ny.Agencia + " e o numero da conta é " + conta_da_Ny.Numero + " Saldo: " + conta_da_Ny.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Vi.Titular + ", o numero da agência é " + conta_da_Vi.Agencia + " e o numero da conta é " + conta_da_Vi.Numero + " Saldo: " + conta_da_Vi.Saldo + ".");

         bool sacar_conta = conta_da_Buru.Sacar(100);
         bool sacar_conta1 = conta_da_Ny.Sacar(100);
         bool sacar_conta2 = conta_da_Vi.Sacar(100);

         Console.WriteLine(" A conta é da " + conta_da_Buru.Titular + ", o numero da agência é " + conta_da_Buru.Agencia + " e o numero da conta é " + conta_da_Buru.Numero + " Saldo: " + conta_da_Buru.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Ny.Titular + ", o numero da agência é " + conta_da_Ny.Agencia + " e o numero da conta é " + conta_da_Ny.Numero  + " Saldo: " + conta_da_Ny.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Vi.Titular + ", o numero da agência é " + conta_da_Vi.Agencia + " e o numero da conta é " + conta_da_Vi.Numero + " Saldo: " + conta_da_Vi.Saldo + ".");
         
         bool depositarconta_da_Buru = conta_da_Buru.Depositar(300);
         bool depositarconta_da_Ny = conta_da_Ny.Depositar(300);
         bool depositarconta_da_Vi = conta_da_Vi.Depositar(300);

          Console.WriteLine(" A conta é da " + conta_da_Buru.Titular + ", o numero da agência é " + conta_da_Buru.Agencia + " e o numero da conta é " + conta_da_Buru.Numero + " Saldo: " + conta_da_Buru.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Ny.Titular + ", o numero da agência é " + conta_da_Ny.Agencia + " e o numero da conta é " + conta_da_Ny.Numero  + " Saldo: " + conta_da_Ny.Saldo + ".");
         Console.WriteLine(" A conta é da " + conta_da_Vi.Titular + ", o numero da agência é " + conta_da_Vi.Agencia + " e o numero da conta é " + conta_da_Vi.Numero + " Saldo: " + conta_da_Vi.Saldo + ".");
         
        }   
    }
}
