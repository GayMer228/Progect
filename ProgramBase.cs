﻿internal class ProgramBase
{

    private static string[] FilterArrayByLength(string[] originalArray)
    {
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in originalArray)
        {

        }}