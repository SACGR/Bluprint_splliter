// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.ExceptionServices;




//konfig
int börjLängd = 25;
int slutLängd = 14;

//De tre dellarna till en bp
string Början = "";
string Slut = "";
//första värdet här hella blocket(Mitten[0,i]), andra är mannet(Mitten[1,i]), Tredje är om den ska behollas(Mitten[2,i])
string[,] Mitten = new string[3, 100000];
//den här listan har inga uprpade block 
string[,] Block = new string[1, 100000];


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
    Början += ("\n" + råFillen[i]);

//Ta bort slutet av fillen
for (int i = 0; i < slutLängd; i++)
{
    int it = råFillen.Count - (slutLängd - i);
    Slut += ("\n" + råFillen[it]);

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
        arbette += "\n" + s;

}
//Arbettlist är en lista som dettar up 

//Räknar ut villket blot somm ligre i varia plats 
for (int i = 0; i < Mitten.Length; i++)
{
    List<string> Arbettlist = Mitten[0,i].Split("\n").ToList();
    Mitten[1,i] = Arbettlist[2];

}

//skapar en lista med alla block inga uprpningar 
for (int i = 0; i < Mitten.GetLength(1); i++)
{
    for (int j = 0; j < Block.GetLength(1); j++)
			{
                if (Mitten[1,i] != Block[0,j])
                  {
                       Block[0, Block.Length] = Mitten[1,i];
                
                       return;

                 }
			}
     

}


//får vetta villka block den ska ta bort och markerar dem i aryn 
//kompilerar



