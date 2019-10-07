using System.IO;
using System.Linq;
using System.Reflection;

public class DCLIB
{
    public string GetConfigFile(string Name)
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
}

