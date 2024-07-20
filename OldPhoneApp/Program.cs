using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;


class Program{

    static void Main(string[] args){
        #region DataPreProcssorForPhoneKeyMap 
        // Dictionary for key to char mapper
        Dictionary<String,String> keyNumStringMap = new Dictionary<String,String>();

        IList<String> buttons = new List<String>(){
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "*",
            "#"
        };

        Char endCharacterCursor = '#';

        IList<String> characterList = new List<String>(){
            "&'(",
            "ABC",
            "DEF",
            "GHI",
            "JKL",
            "MNO",
            "PQRS",
            "TUV",
            "WXYZ",
            "|x|",
            "|=>|"
        };


        //TODO: Input validation between two list
        for(int i = 0; i < buttons.Count;i++){
            keyNumStringMap.Add(buttons[i],characterList[i]);
        }

        // Testing KeyMap With Print
        //  foreach (var kvp in keyNumStringMap)
        // {
        //     Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        // }
        
        #endregion

        #region InputProcessor

        StringBuilder inputBuilder = new StringBuilder();
        while(true){
            char inputChar = (char) Console.Read();
            if(inputChar == endCharacterCursor) break;
            inputBuilder.Append(inputChar);
        }    

        String userInput = inputBuilder.ToString();   
        #endregion

        #region InputProcessingToSplit

        String[] numLists = userInput.Split(' ');
        
        #endregion


        #region NumPressToCharacterMapping
        // "*" means deletion of last Appeared Character
        IList<String> results = new List<String>();
        Char prevNumber='@';
        for(int i = 0; i < numLists.Length;i++){
            int cnt = 0;
            String word = "";
            for(int j = 0; j < numLists[i].Length;j++){
                if(j == 0) {
                    prevNumber = numLists[i][j];
                    cnt = 1;
                    continue;
                }
                if(prevNumber == numLists[i][j]) {
                    cnt++;
                   
                }
                else {
                    // TODO: Complete the business logic
                    if(numLists[i][j] == '*'){
                        prevNumber = '@';
                        cnt = 0;
                        continue;
                    } 
                    String charList = keyNumStringMap[prevNumber.ToString()];
                    int index = cnt % charList.Length;
                    word += charList[index];
                    prevNumber = numLists[i][j];
                    cnt = 1;
                }

                if(j == numLists[i].Length - 1){
                    results.Add(word);
                    word = "";
                    prevNumber = '@';
                    cnt = 0;
                }
            }
        }      

        #endregion 

    }
}
