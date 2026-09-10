/* Skriv ett konsolprogram som håller reda på en inköpslista med namn och pris för varje vara.
Eftersom vi inte använder objekt i den här delen håller du ihop datan med två parallella listor — en
List<string> för namnen och en List<int> för priserna — där samma index hör ihop (names[i] kostar
prices[i]).
Programmet ska hela tiden visa listan som en numrerad lista med totalsumma, t.ex.:
1. Mjölk - 15 kr
2. Bröd - 32 kr
3. Ost - 89 kr
Totalt: 136 kr
Input från användaren:
En vara: skriv ett varunamn (text). Programmet frågar då efter priset (ett heltal) och lägger till varan
sist i listan. Skriver användaren något som inte är ett heltal som pris ska varan inte läggas till.
Ett nummer: varan på den positionen tas bort ur listan (både namn och pris).
Om användaren anger ett nummer som inte finns i listan ska programmet säga till i stället för att
krascha.
*/
string[] instructions = ["Välkommen till inköpslistan",
"* Utöka inköpslistan genom att skriva vara och pris",
"* Ta bort en vara från listan genom att skriva siffran framför"];
Console.WriteLine(string.Join("\n", instructions));

List<string> products = [];
List<int> prices = [];
int price;

while (true)
{
    Console.WriteLine("Vilken vara vill du lägga till i listan?");
    string product = Console.ReadLine()!;
    Console.WriteLine("Vad är priset på varan?");
    if(int.TryParse(Console.ReadLine(), out price))
    {
        products.Add(product);
        prices.Add(price);
    } else
    {
        Console.WriteLine("Ogiltigt pris, försök igen");
    }
}
