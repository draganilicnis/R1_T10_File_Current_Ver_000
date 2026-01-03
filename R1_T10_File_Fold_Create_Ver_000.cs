// R1 T10 File: https://petlja.org/sr-Latn-RS/kurs/17862/42/2424
// https://github.com/draganilicnis/R1_T10_File_01_Write_TXT_HTML
// https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.createdirectory?view=net-10.0
using System;
using System.IO;
class R1_T10_File_Fold_Create_Ver_000
{
    // Globalne promenljive
    public static string sFold_Name_Base_Path_Full = @"D:\Test\Test_2026";
    static void Main()
    {
        Menu_Main();
    }

    static void Menu_Main()
    {
        Korak_001_Fold_Base_Ini();

        // ...

        // Korak_999_Fold_Base_Delete();
    }

    static void Korak_001_Fold_Base_Ini()
    {
        int iFold_Base_Create = Korak_001_Fold_Base_Create_Test_2016();
        Console.WriteLine(iFold_Base_Create);
    }
    static int Korak_001_Fold_Base_Create_Test_2016()
    {
        // string sFold_Name_Base_Path_Full = @"D:\Test\Test_2026";
        DirectoryInfo di;
        if (Directory.Exists(sFold_Name_Base_Path_Full)) return 0;
        try
        {
            di = Directory.CreateDirectory(sFold_Name_Base_Path_Full);  // Program puca, ako ne postoji particija D
            return 1;
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("The caller does not have the required permission to create `{0}`", sFold_Name_Base_Path_Full);
            return -1;
        }
    }

    static void Korak_999_Fold_Base_Delete()
    {
        Console.ReadKey();
        // Delete the directory.
        int iFold_Base_Delete = Korak_999_Fold_Base_Delete_Test_2016();
        Console.WriteLine(iFold_Base_Delete);
        // di.Delete();
        // Console.WriteLine("The directory was deleted successfully.");
    }
    static int Korak_999_Fold_Base_Delete_Test_2016()
    {
        // string sFold_Name_Base_Path_Full = @"D:\Test\Test_2026";
        // DirectoryInfo di;
        if (!Directory.Exists(sFold_Name_Base_Path_Full)) return 0;
        try
        {
            Directory.Delete(sFold_Name_Base_Path_Full, false);     // Ne ide u kantu za djubre
            return 1;
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("The caller does not have the required permission to delete `{0}`", sFold_Name_Base_Path_Full);
            return -1;
        }
    }
}
