// See https://aka.ms/new-console-template for more information


using System;



Console.WriteLine("Var ligger fillen\nom blank letar den i kotalågen dår .exe fillen ligger");
string RutFillVäg = Console.ReadLine();
string pafROt = Directory.GetCurrentDirectory();
if (RutFillVäg != "")
    pafROt = RutFillVäg;   



Console.WriteLine(pafROt+ "\nVad hetter fillen\nOm blank kommer den att hetta bp.spc");
string FillVäg = Console.ReadLine();
if (FillVäg == "")
    FillVäg = "bp.spc";
string HellaFillVäg = pafROt + "\\" + FillVäg;
Console.WriteLine("Hella Fillväg " + HellaFillVäg);

List<string> strings = File.ReadAllLines(HellaFillVäg).ToList();
string arbetare = "";
List<string> resultat = new List<string>();


Console.ReadLine();
foreach (string s in strings)
{

    Console.WriteLine(s);
    if (s.Contains("</MyObjectBuilder_CubeBlock>") || (s.Contains("</ShipBlueprints>")))
    {
        //Console.ReadLine();
        arbetare += "\n" + s;
        resultat.Add(arbetare);
        arbetare = "";
    }
    else
        arbetare += "\n" + s;
}
resultat.Add("</Definitions>");

Console.WriteLine("Klar");
Console.WriteLine(resultat.Count);
Console.ReadLine();
//skriver ut alla raddenr separat 
//foreach (string s in resultat)
//{
//    Console.WriteLine(s);
//    //Console.ReadLine();
//}

List<string> blackNamn = new List<string>();

for (int i = 1; i < resultat.Count - 2; i++)
{
    string[] nuvarandeBlack = resultat[i].ToString().Split("\n");
    Console.WriteLine(nuvarandeBlack[2]);
    blackNamn.Add(nuvarandeBlack[2]);
}
List<string> blackNamnIngUprepning = new List<string>();
for (int i = 0; i < blackNamn.Count; i++)
{
    if (blackNamnIngUprepning.Contains(blackNamn[i]) == false)
        blackNamnIngUprepning.Add(blackNamn[i]);


}

Console.WriteLine("alla block typrer");

foreach (string s in blackNamnIngUprepning)
{
    Console.WriteLine(s);

}
Console.WriteLine("Villka vill du ta bort\n(k)när du är klar");
bool e = true;
List<string> VadDemVillTaBort = new List<string>();
while(e == true)
{
    string Skrivet = Console.ReadLine();
    if (Skrivet == "k")
    {
        e = false;
        Console.WriteLine("Du har jort dina vall, börjar kompilerar");

    }
        

    else
    {
        VadDemVillTaBort.Add(Skrivet);
        Console.WriteLine("Du la till " + Skrivet);
    }
        

}
string Prudokt = "";
Prudokt += resultat[0];
Console.WriteLine("läger till" + resultat[0]);
for (int i = 1; i < resultat.Count - 2; i++)
{
    if (!VadDemVillTaBort.Contains(blackNamn[i-1]))
    {
        Prudokt += "\n" + resultat[i];
        Console.WriteLine("läger till" + resultat[i]);

    }
    else
        Console.Write("-");
        

}
Console.WriteLine("Kalr mind dina vall lägger till slutstycke");

Prudokt += resultat[resultat.Count - 2];
Prudokt += "\n" + resultat[(resultat.Count - 1)];

Console.WriteLine(Prudokt);
Console.WriteLine("Vad ska fillen hetta");
string FillensNamn = Console.ReadLine();
if (FillensNamn == "") { 
    FillensNamn = "bp.spc"
}
Console.WriteLine("Din fill hetter " + FillensNamn);
File.WriteAllLines(pafROt+"\\bp.sbc", Prudokt.Split('\n'));
Console.WriteLine("din fill liger nu i "+ pafROt + "\\bp.sbc")
Console.ReadLine();




