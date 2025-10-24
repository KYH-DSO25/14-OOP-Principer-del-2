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

