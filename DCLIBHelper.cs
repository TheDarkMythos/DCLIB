using System.IO;
using System.Linq;
using System.Reflection;

public class DCLIB
{
    public static string GetConfigFile(string Name)
    {
        if (File.Exists(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.LastIndexOf(@"\") + 1) + Name))
        {
            return File.ReadAllText(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.LastIndexOf(@"\") + 1) + Name);
        }
        else
        {
            try
            {
                var assembly = Assembly.GetEntryAssembly();

                var resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith(Name));

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }
    }

    public static string Base64Decode(string base64EncodedData)
    {
        try
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        catch
        {
            return null;
        }
    }
}

