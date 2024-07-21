namespace PhoneKeyPad;

public class RemovePrevChar: NumKeyWithExecBehavior
{
     public RemovePrevChar(char keyNumPad) : base(keyNumPad)
    {
    }

    public new String ExecuteBehavior(int pressingNumber, string currentWord)
    {
        if(pressingNumber >= 1 && !string.IsNullOrEmpty(currentWord)){
            currentWord = currentWord.Substring(0,currentWord.Length - pressingNumber);
        }
        
        return currentWord;
    }
}