using System.Text.RegularExpressions;

namespace PhoneKeyPad;

public class SpaceChar : NumKeyWithExecBehavior
{
     public SpaceChar(char keyNumPad) : base(keyNumPad)
    {
    }

    public new String ExecuteBehavior(int pressingNumber, string currentWord)
    {
        for(int i = 0; i < pressingNumber;i++)
            currentWord += " ";
        return currentWord;
    }
}