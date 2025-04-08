using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class ExampleScript : MonoBehaviour
{
    
    //Name Darf frei gewählt werden
    //private kleingeschrieben, public großgeschrieben
    private bool myFirstBooleam;
    private int myFirstInteger;
    private int myCounterInteger;
    private int mySecondInteger;
    private string myfirstString;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        Debug.Log("Das Programm ist gestartet");

        myFirstBooleam = true;
        myFirstInteger = 8;
        mySecondInteger = 5;
        myCounterInteger = 0;
        myfirstString = "Hello World";
        
        int result = myFirstInteger + mySecondInteger;

        myfirstString = myfirstString + ",Go Fight"; 
        
        Debug.Log("myFirstBool is: " + myFirstBooleam);
        Debug.Log("myFirstInteger is: " + myFirstInteger);
        Debug.Log("myfirstString is: " + myfirstString);
        
        Debug.Log("int1 + int2 = " + result);

        // result = result + 1;
        //result += 1;
        result++;
        
        Debug.Log("result + 1 = " + result);
        
        // MyFirstFunction();// Hier rufen wir unsere erste eigene Funktion auf
        // es geht erst wieter, wenn die Funktion komplett abgeschlossen wurde
        
        Debug.Log("Start ist zu Ende");
        
    }
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Das Programm läuft");
        myCounterInteger++;
        Debug.Log("myCounterIntreger" + myCounterInteger);
    }
    //unsere erste Funktion
    // Namen können wir frei aussuchen - sollte aber natürlich irgendwie die Funktion beschreiben
    // Funktionen werden großgeschrieben 
    
    // public, wenn sie von anderen scripts oder z.B. von Buttons mit verwendet werden soll 
    
  public void MyFirstFunction()
    {
       Debug.Log("meine Funktion wurde ausgeführt");
    }
}
