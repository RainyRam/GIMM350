//This code is what allows the turtle to speak when you interact with one of the rocks.
//This is code that was not in any of our tutorials.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Turtle : MonoBehaviour
{
    public TextMeshPro turtleTalk;
    private bool isClicked = false;

    void Start()
    {
        
    }

    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "rock")
        {
            turtleTalk.text = "Hey, that's my rock!";
            print("Rock Grabbed");
        }
    }
}
