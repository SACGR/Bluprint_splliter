// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.ExceptionServices;


//erors
//error CS1929: 'string' does not contain a definition for 'Append' and the best extension method overload 'Queryable.Append<string>(IQueryable<string>, string)' requires a receiver of type 'IQueryable<string>'
//error CS1929: 'string' does not contain a definition for 'Append' and the best extension method overload 'Queryable.Append<string>(IQueryable<string>, string)' requires a receiver of type 'IQueryable<string>'
//error CS0103: The name 'arbetare' does not exist in the current context
//error CS0029: Cannot implicitly convert type 'string[]' to 'System.Collections.Generic.List<string>'
//error CS0136: A local or parameter named 'i' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
//warning CS8600: Converting null literal or possible null value to non-nullable type.
//warning CS8600: Converting null literal or possible null value to non-nullable type.
//warning CS8600: Converting null literal or possible null value to non-nullable type.
//error CS0165: Use of unassigned local variable 'Mitten'
//error CS0165: Use of unassigned local variable 'Block'






//konfig
int börjLängd = 25;
int slutLängd = 14;

//De tre dellarna till en bp
string Början = "";
string Slut = "";
//första värdet här hella blocket(Mitten[0,i]), andra är mannet(Mitten[1,i]), Tredje är om den ska behollas(Mitten[2,i])
string[,] Mitten;
//den här listan har inga uprpade block 
string[,] Block;


Console.WriteLine("Var ligger fillen\nom blank letar den i kotalågen dår .exe fillen ligger");
string RutFillVäg = Console.ReadLine();
string pafROt = Directory.GetCurrentDirectory();
if (RutFillVäg != "")
    pafROt = RutFillVäg;

Console.WriteLine(pafROt + "\nVad hetter fillen\nOm blank kommer den att hetta bp.spc");
string FillVäg = Console.ReadLine();
if (FillVäg == "")
    FillVäg = "bp.spc";
string HellaFillVäg = pafROt + "\\" + FillVäg;
Console.WriteLine("Hella Fillväg " + HellaFillVäg);

List<string> råFillen = File.ReadAllLines(HellaFillVäg).ToList();









//Ta bort början av fillen
for (int i = 0; i < börjLängd; i++)
    Början.Append("\n" + råFillen[i]);

//Ta bort slutet av fillen
for (int i = 0; i < slutLängd; i++)
{
    int it = råFillen.Count - (slutLängd - i);
    Slut.Append("\n" + råFillen[it]);

}

//arbete är den fillen som bygs på när prubramet kör 
string arbette = "";


//spara varje block i en ary mad namnet,blockdata,om den ska sparas 
for (int i = börjLängd; i < (råFillen.Count-(slutLängd+börjLängd)); i++)
{ 
    string s = råFillen[i];
    Console.WriteLine(s);
    if (s.Contains("</MyObjectBuilder_CubeBlock>"))
    {
        Console.WriteLine(i);
        arbette += "\n" + s;
        //läg till coden som leger till Arbette i resultatet
        Mitten[0,i] = arbette;
        arbette = "";
    }
    else
        arbetare += "\n" + s;

}
//Arbettlist är en lista som dettar up 

//Räknar ut villket blot somm ligre i varia plats 
for (int i = 0; i < Mitten.Length; i++)
{
    List<string> Arbettlist = Mitten[0,i].Split("\n");
    Mitten[1,i] = Arbettlist[2];

}

//skapar en lista med alla block inga uprpningar 
for (int i = 0; i < Mitten.GetLength(1); i++)
{
    for (int i = 0; i < Block.GetLength(1); i++)
			{
                if (Mitten[1,i] != Block[0,i])
                  {
                       Block[0,i+1] = Mitten[1,i];
                       return;

                 }
			}
     

}


//får vetta villka block den ska ta bort och markerar dem i aryn 
//kompilerar



