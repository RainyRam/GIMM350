using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities
{

    public static string ProcessText(string input)
    {

        int words = 1;
        int letters = 0;
        double average;

        foreach (char word in input)
        {
            if (char.IsSeparator(word))
            {
                words++;
            }
        }

        foreach (char letter in input)
        {
            if (char.IsLetter(letter) && !char.IsSeparator(letter))
            {
                letters++;
            }
        }

        average = letters / words;
        return average.ToString();

    }
}
