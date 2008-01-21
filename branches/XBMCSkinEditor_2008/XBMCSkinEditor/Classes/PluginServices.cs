using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
namespace XBMCSkinEditor.Classes
{

    internal class PluginServices
    {

        public struct AvailablePlugin
        {
            public string AssemblyPath;
            public string ClassName;
        }

        public static AvailablePlugin[] FindPlugins(string strPath, string strInterface)
        {

            List<AvailablePlugin> Plugins = new List<AvailablePlugin>();
            string[] strDLLs;
            int intIndex;
            Assembly objDLL;
            //Go through all DLLs in the directory, attempting to load them
            if (!System.IO.Directory.Exists(strPath + "Plugins")) {
                return null;
            }
            strDLLs = Directory.GetFileSystemEntries(strPath + "Plugins", "SkinEditor.Plugin.*.dll");
            for (intIndex = 0; intIndex <= strDLLs.Length - 1; intIndex++)
            {
                try
                {
                    objDLL = Assembly.LoadFrom(strDLLs[intIndex]);
                    ExamineAssembly(objDLL, strInterface, Plugins);
                }
                catch (Exception)
                {
                    //Error loading DLL, we don't need to do anything special
                }
            }

            //Return all plugins found
            AvailablePlugin[] Results = new AvailablePlugin[Plugins.Count];

            if (Plugins.Count != 0)
            {
                Plugins.CopyTo(Results);
                return Results;
            }
            else
            {
                return null;
            }

        }

        private static void ExamineAssembly(Assembly objDLL, string strInterface, List<AvailablePlugin> Plugins)
        {
        
        Type objInterface;
        AvailablePlugin Plugin;
        
        //Loop through each type in the DLL
        foreach (Type objType in objDLL.GetTypes()) {
            //Only look at public types
            if (objType.IsPublic == true) {
                //Ignore abstract classes
                if (!((objType.Attributes & TypeAttributes.Abstract) == TypeAttributes.Abstract)) {
                    
                    //See if this type implements our interface
                    Type[] foo = objType.GetInterfaces();
                   
                    objInterface = objType.GetInterface(strInterface, true);
                    
                    if ((objInterface != null)) {
                        //It does
                        Plugin = new AvailablePlugin();
                        Plugin.AssemblyPath = objDLL.Location;
                        Plugin.ClassName = objType.FullName;
                        Plugins.Add(Plugin);
                    }
                    
                }
            }
        }
        
    }

        public static SkinEditor.Interfaces.IPlugin CreateInstance(AvailablePlugin Plugin)
        {
            
            Assembly objDLL;
            SkinEditor.Interfaces.IPlugin objPlugin;

            try
            {
                //Load dll
                objDLL = Assembly.LoadFrom(Plugin.AssemblyPath);
                //Create and return class instance
                objPlugin = (SkinEditor.Interfaces.IPlugin)objDLL.CreateInstance(Plugin.ClassName);
            }
            catch (Exception)
            {
                return null;
            }
            return objPlugin;

        }

    }
}
