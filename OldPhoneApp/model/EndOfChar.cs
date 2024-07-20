namespace PhoneKeyPad;

public class EndOfChar : NumKeyWithExecBehavior
{
    public EndOfChar(char keyNumPad) : base(keyNumPad)
    {
    }

    public new void ExecuteBehavior(int pressingNumber, string currentWord)
    {
        // Implement the specific behavior here
    }
}