using System;

namespace SkinEditor.Interfaces
{
    public interface IPlugin
    {
        PluginDetails PluginDetails
        {
            get;
        }
        System.Collections.Generic.List<InputParameter> InputParameters
        {
            get;
            set;
        }
        System.Collections.Generic.List<OutputParameter> OutputParameters
        {
            get;
        }

        void Initialize(IHost Host);
        void Start();
        void HostClosing(ref bool Cancel);
        void Close();
        void About();
        void Settings();

    }
}
