/*
*   2.  En bank har olika slags konton för sina kunder: sparkonton, lånekonton, och bolånekonton. 
*       Kunder kan vara personer eller företag.
*       Alla konton har kund, saldo och räntesats (årlig). 
*       Sparkonton kan hantera insättningar och uttag. 
*       På lånekonto och bolånekonto kan man bara göra insättningar.
*       Alla konton kan beräkna sina räntor för en given period (i månader). 
*       I det gemensamma fallet beräknas räntan enligt numberOfMonths * interestRate / 12.
*       
*       Lånekonton har ingen ränta de första 3 månaderna om kontoinnehavaren är en person 
*       och de första 2 månaderna om innehavaren är ett företag
*       
*       Sparkonton har ingen ränta om deras saldo är positivt och mindre än 10000
*       
*       Bolånekonton har halv ränta de första 12 månaderna för företag och 
*       ingen ränta de första 6 månaderna för personer
*       
*       Din uppgift är att skriva ett program som modellerar banken genom klasser och gränssnitt. 
*       Du behöver identifiera vilka klasser, gränssnitt, basklasser och 
*       abstrakta metoder som behövs. 
*       
*       Implementera sedan ränteberäkningarna genom överskrivna metoder.
*/

using _02_Bank;
using _02_Bank.AccountTypes;
using _02_Bank.Enum;

var bank = new Bank("International KYH Bank");

bank.AddAccount(
    new DepositAccount(CustomerType.Individual, 2330, 4.5m).WithDraw(200.0m), // Testa uttag
    new LoanAccount(CustomerType.Company, 10000m, 25).Deposit(2500.75m),    // Testa insättning
    new LoanAccount(CustomerType.Individual, 444, 44),          // Ska strax tas bort
    new MortgageAccount(CustomerType.Company, 2300, 15)
   );

Console.WriteLine(bank);

bank.RemoveAccount(new LoanAccount(CustomerType.Individual, 444, 44));
Console.WriteLine("\n\nAfter removal of account:");
Console.WriteLine(bank);

/* ------------ */

Console.WriteLine(new DepositAccount(CustomerType.Individual, 2330, 45).CalculateInterestAmount(20));

Console.WriteLine(new LoanAccount(CustomerType.Company, 250, 25).Deposit(250.23m).CalculateInterestAmount(15));

Console.WriteLine(new MortgageAccount(CustomerType.Company, 2300, 15).CalculateInterestAmount(45) + "\n\n");

/* ------------ */

Console.WriteLine(new DepositAccount(CustomerType.Individual, 2330, 45));






Console.Write("\n\nTryck på en tangent för att stänga fönstret");
Console.ReadKey();