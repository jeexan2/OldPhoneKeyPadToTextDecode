namespace PhoneKeyPad;

public class NumKeyWithExecBehavior : PhoneKey, KeyPressFunc
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