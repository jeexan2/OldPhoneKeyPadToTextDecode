namespace PhoneKeyPad;

public class NumKeyWithExecBehavior : PhoneKey, IKeyPressFunc
{
    protected Boolean isAltBehaviour;
    public NumKeyWithExecBehavior(char keyNumPad) : base(keyNumPad)
    {
        isAltBehaviour = true;
    }

    public void ExecuteBehavior(int pressingNumber, string currentWord)
    {
        // Implement the behavior here
    }

}