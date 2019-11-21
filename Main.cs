using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DCRatPlugin
{
    public void OnLoad(string HOST, string TOKEN)
    {
        string PluginConfig = DCLIB.GetConfigFile("MyConfigFile.cfg");

        string BaseDecodedPluginConfig = DCLIB.Base64Decode(DCLIB.GetConfigFile("MyConfigFile.cfg"));

        //YOUR CODE
    }
}

