namespace PhoneKeyPad;


public interface IInputBuilder{
    public List<PhoneKey> inputStringToPhoneKeyConverter(String input);
}