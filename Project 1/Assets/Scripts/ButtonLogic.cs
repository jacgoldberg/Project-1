using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    //Activates on press of ingame button.
   public void onButtonPress()
    {
        //Opens and Writes to logFile
        using (System.IO.StreamWriter logFile = new System.IO.StreamWriter(@"C:\Users\goldb\Desktop\LogFile.txt", true))
        {
            logFile.WriteLine("["
                + System.DateTime.Now
                + "]"
                + "Button Pressed"
                + "\n");
        }
    }
}
