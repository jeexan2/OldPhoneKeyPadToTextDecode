using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;


class Program{

    static void Main(string[] args){
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

        String endCharacterCursor = "#";

        IList<String> characterList = new List<String>(){
            "&'(",
            "abcABC",
            "defDEF",
            "ghiGHI",
            "jklJKL",
            "mnoMNO",
            "pqrsPQRS",
            "tuvTUV",
            "wxyzWXYZ",
            "|x|",
            "|=>|"
        };


        //TODO: Input validation between two list
        for(int i = 0; i < buttons.Count;i++){
            keyNumStringMap.Add(buttons[i],characterList[i]);
        }
        


    }
}
