// https://stackoverflow.com/questions/6660512/how-to-get-csc-exe-path
// dir /s %WINDIR%\CSC.EXE
// dir %WINDIR%\Microsoft.NET\Framework64\csc.exe /s/b
// https://github.com/draganilicnis/R1_T10_File_Current_Ver_000/blob/main/R1_T10_File_CSC_Path_Ver_000.cs

using System;
using System.IO;                        // Zbog Path.Combine()
using System.Runtime.InteropServices;   // Zbog RuntimeEnvironment.GetRuntimeDirectory()

class R1_T10_File_CSC_Path_Ver_000
{
    static void Main()
    {
        // You can use System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()
        var frameworkPath = RuntimeEnvironment.GetRuntimeDirectory();
        var cscPath = Path.Combine(frameworkPath, "csc.exe");

        Console.WriteLine(frameworkPath);   // 332 (251225): C:\Windows\Microsoft.NET\Framework\v4.0.30319
        Console.WriteLine(cscPath);         // 332 (251225): C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe

        // **********************************
        // VAZNA NAPOMENA:
        // Prva verzija koda je nastala u kabinetu 332 u cetvrtak 25.12.2025 u 13h (nakon nastave u 233 sa 2/2)
        // Ova verzija koda na racunaru kod kuce je nastala u subotu 03.01.2026 u 20h
        // Putanja do CSC.Exe datoteke je potpuno ista (identicna) na racunaru kod kuce (Bingo) kao i na racunaru u kabinetu 332.
        // **********************************

        Console.ReadKey();
    }
}
