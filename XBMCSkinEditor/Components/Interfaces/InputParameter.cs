

namespace SkinEditor.Interfaces
{
    public class InputParameter
    {
        
        string strDescription;
        ValueType valType;
        object objValue;
        string strParameters;
        bool blnOptionalValue;
        
        public enum ValueType
        {
            Text = 0,
            Number = 1,
            Hex = 2,
            Color = 3,
            File = 4
        }
        
        public InputParameter(string Description, ValueType ValueType, bool OptionalValue)
        {
            strDescription = Description;
            valType = ValueType;
            blnOptionalValue = OptionalValue;
            objValue = null;
            strParameters = "";
        }
        public InputParameter(string Description, ValueType ValueType, bool OptionalValue, object Value, string Parameters)
        {
            strDescription = Description;
            valType = ValueType;
            blnOptionalValue = OptionalValue;
            objValue = Value;
            strParameters = Parameters;
        }

        public string Description {
            get { return strDescription; }
        }
        
        public ValueType Type {
            get { return valType; }
        }
        
        public bool OptionalValue {
            get { return blnOptionalValue; }
        }
        
        public object Value {
            get { return objValue; }
            set { objValue = value; }
        }
        
        public string Parameters {
            get { return strParameters; }
            set { strParameters = value; }
        }
        
    }
}
