namespace PhoneKeyPad;

public class EndOfChar : NumKeyWithExecBehavior
{
    public EndOfChar(char keyNumPad) : base(keyNumPad)
    {
    }

    public new String ExecuteBehavior(int pressingNumber, string currentWord)
    {
        return currentWord;
    }
}