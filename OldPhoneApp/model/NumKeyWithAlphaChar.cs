namespace PhoneKeyPad;

public class NumKeyWithAlphaChar : PhoneKey 
{
     public Dictionary<int, char> IndexToTextValue { get; set; }

    public NumKeyWithAlphaChar(char keyNumPad) : base(keyNumPad)
    {
        IndexToTextValue = new Dictionary<int, char>();
    }
}