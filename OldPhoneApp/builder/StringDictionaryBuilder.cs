namespace PhoneKeyPad;


public class StringDictionaryBuilder : IStringDictionaryBuilder{

    public StringDictionaryBuilder(){

    }
    public Dictionary<int,char> getStringWithIndex(String keyText){
        Dictionary<int,char> textWithIndex = new Dictionary<int, char>();
        for(var i = 0; i < keyText.Length;i++){
            textWithIndex.Add(i,keyText[i]);
        }
        return textWithIndex;
    }

}

