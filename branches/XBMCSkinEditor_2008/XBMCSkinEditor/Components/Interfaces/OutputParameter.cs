using System;
using System.Collections.Generic;
using System.Text;

namespace SkinEditor.Interfaces
{
    public class OutputParameter
    {

        string strDescription;
        ValueType valType;
        object objValue;
        string strParameters;

        public enum ValueType
        {
            Text = 0,
            Number = 1,
            Hex = 2,
            File = 3,
            Color = 4
        }

        public OutputParameter(string Description, ValueType ValueType, object Value)
        {
            strDescription = Description;
            valType = ValueType;
            objValue = Value;
        }

        public string Description
        {
            get { return strDescription; }
        }

        public ValueType Type
        {
            get { return valType; }
        }

        public object Value
        {
            get { return objValue; }
        }

    }
}
