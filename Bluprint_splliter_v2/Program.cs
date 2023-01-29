// See https://aka.ms/new-console-template for more information

using System;

//konfig
int börjLängd = 25;
int slutLängd = 14;





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


 
string Början = "";
string Slut = "";
//första värdet här hella blocjet, andra är mannet, Tredje är om den ska behollas 
//Behöver förbetras
//string [] Miten;


//Ta bort början av fillen
for (int i = 0; i < börjLängd; i++)
    Början.Append("\n" + råFillen[i])

//Ta bort slutet av fillen
for (int i = 0; i < slutLängd; i++)
{
    int it = råFillen.Count - (slutLängd - i);
    Slut.Append("\n" + råFillen[it])

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
        //Console.ReadLine();
        arbette += "\n" + s;
        //läg till coden som leger till Arbette i resultatet
        arbette = "";
    }
    else
        arbetare += "\n" + s;


}




//får vetta villka block den ska ta bort och markerar dem i aryn 
//kompilerar



