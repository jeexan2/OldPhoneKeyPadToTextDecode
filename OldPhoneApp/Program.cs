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
        var one = new NumKeyWithAlphaChar('1',stringDictionaryBuilder,"&;(");
        var two = new NumKeyWithAlphaChar('2',stringDictionaryBuilder,"abc");
        var three = new NumKeyWithAlphaChar('3',stringDictionaryBuilder,"def");
        var four = new NumKeyWithAlphaChar('4',stringDictionaryBuilder,"ghi");
        var five = new NumKeyWithAlphaChar('5',stringDictionaryBuilder,"jkl");
        var six = new NumKeyWithAlphaChar('6',stringDictionaryBuilder,"mno");
        var seven = new NumKeyWithAlphaChar('7',stringDictionaryBuilder,"pqrs");
        var eight = new NumKeyWithAlphaChar('8',stringDictionaryBuilder,"tuv");
        var nine = new NumKeyWithAlphaChar('9',stringDictionaryBuilder,"wxyz");
        
        var starPhoneKey = new RemovePrevChar('*');
        var spacePhoneKey = new SpaceChar(' ');
        var hashPhoneKey  = new EndOfChar('#');
    }
}
