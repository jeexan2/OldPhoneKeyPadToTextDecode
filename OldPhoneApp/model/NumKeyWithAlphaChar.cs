namespace PhoneKeyPad;

public class NumKeyWithAlphaChar : PhoneKey, IKeyPressFunc 
{
     public Dictionary<int, char> indexToTextValue { get; set; }

     private IStringDictionaryBuilder stringDictionaryBuilder;

    public NumKeyWithAlphaChar(char keyNumPad,
            IStringDictionaryBuilder stringDictionaryBuilder_,
            String keyText 
        ) : base(keyNumPad)
    {
        stringDictionaryBuilder = stringDictionaryBuilder_;
        indexToTextValue = stringDictionaryBuilder.getStringWithIndex(keyText);
    }

     public String ExecuteBehavior(int pressingNumber, string currentWord)
    {
        // Implement the behavior here
        return "";
    }
}