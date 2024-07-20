namespace PhoneKeyPad;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;


class Program{

    static void Main(string[] args){
       
        // Testing creation
        IList<PhoneKey> phoneKeys = new List<PhoneKey>();
        IStringDictionaryBuilder stringDictionaryBuilder = new StringDictionaryBuilder();
        PhoneKey one = new NumKeyWithAlphaChar('1',stringDictionaryBuilder,"&;(");
        PhoneKey two = new NumKeyWithAlphaChar('2',stringDictionaryBuilder,"abc");
        PhoneKey three = new NumKeyWithAlphaChar('3',stringDictionaryBuilder,"def");
        PhoneKey four = new NumKeyWithAlphaChar('4',stringDictionaryBuilder,"ghi");
        PhoneKey five = new NumKeyWithAlphaChar('5',stringDictionaryBuilder,"jkl");
        PhoneKey six = new NumKeyWithAlphaChar('6',stringDictionaryBuilder,"mno");
        PhoneKey seven = new NumKeyWithAlphaChar('7',stringDictionaryBuilder,"pqrs");
        PhoneKey eight = new NumKeyWithAlphaChar('8',stringDictionaryBuilder,"tuv");
        PhoneKey nine = new NumKeyWithAlphaChar('9',stringDictionaryBuilder,"wxyz");
        // TODO: Special Key check
        PhoneKey hashPhoneKey = new RemovePrevChar('*');
        PhoneKey spacePhoneKey = new SpaceChar(' ');
        PhoneKey starPhoneKey  = new EndOfChar('#');
    }
}
