using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Clears File at game start up
        System.IO.File.WriteAllText(@"C:\Users\goldb\Desktop\LogFile.txt", string.Empty);
        WriteToLog("System Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Logic for checking when space bar is pressed
        if (Input.GetButtonDown("Jump"))
        {
            WriteToLog("Space Bar Pressed");        
        }
    }
    //Writes to logFile
    void WriteToLog(string message)
    {
        using(System.IO.StreamWriter logFile = new System.IO.StreamWriter(@"C:\Users\goldb\Desktop\LogFile.txt", true))
        {
            logFile.WriteLine("["
                + System.DateTime.Now
                + "]"
                + message 
                + "\n");
        }
    }
    //Logic for quitting the application
    void OnApplicationQuit()
    {
        WriteToLog("System Stop");
    }
}
