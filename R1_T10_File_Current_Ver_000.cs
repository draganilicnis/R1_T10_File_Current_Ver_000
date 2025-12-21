using System;
using System.IO;
class R1_T10_File_Current_Ver_000
{
    static void Main()
    {
        Console.WriteLine("R1_T10_File_Current_Ver_000");
        
        string sFold_Name_Current = Directory.GetCurrentDirectory();
        Console.WriteLine(sFold_Name_Current);

        string sFold_Name_Docm = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string sFold_Name_Syst = Environment.GetFolderPath(Environment.SpecialFolder.System);
        string sFold_Name_Pers = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        string sFold_Name_User = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string sFold_Name_AppD = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string sFold_Name_CApD = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        string sFold_Name_LApD = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        Console.WriteLine(sFold_Name_Docm);
        Console.WriteLine(sFold_Name_Syst);
        Console.WriteLine(sFold_Name_Pers);
        Console.WriteLine(sFold_Name_User);
        Console.WriteLine(sFold_Name_AppD);
        Console.WriteLine(sFold_Name_CApD);
        Console.WriteLine(sFold_Name_LApD);

        string sFold_Name_Down = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        Console.WriteLine(sFold_Name_Down);

        string sFold_Name_VSsc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source");
        Console.WriteLine(sFold_Name_VSsc);
        string sFold_Name_VSrp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
        Console.WriteLine(sFold_Name_VSrp);
    }
}
