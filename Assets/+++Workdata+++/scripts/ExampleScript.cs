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

    private float myFirstFloat = 3.234f;
    private char myCharacter = 'n'; 
    
    // private GameObjekt myGameObjekt; //Ein Objekt von Unity in einer Szene 
    // Ist Momentan leer (eine leere Kiste) - wir können aber ein Objekt aus unserer Szene hinzufügen
    // und es so in unserem Script benutzbar machen
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        Debug.Log("Das Programm ist gestartet");

        myFirstBooleam = true;
        myFirstInteger = 12;
        mySecondInteger = 5;
        myCounterInteger = 0;
        myfirstString = "Hello World";
        

        myfirstString = myfirstString + ",Go Fight"; 
        
        Debug.Log("myFirstBool is: " + myFirstBooleam);
        Debug.Log("myFirstInteger is: " + myFirstInteger);
        Debug.Log("myfirstString is: " + myfirstString);
        
        // +
        int result = myFirstInteger + mySecondInteger;
        Debug.Log("int1 + int2 = " + result);   
        
        // -
        int result1 = myFirstInteger - mySecondInteger;
        Debug.Log("int1 - int2 = " + result1);
       
        // /
        float result2 = (float) myFirstInteger / mySecondInteger;
        Debug.Log("int3 / int2 = " + result2);
       
        // * 
        int result3 = myFirstInteger * mySecondInteger;
        //um) den ersten integer in ein float, damit wir als Ergebniss aus eine float-Zahl bekommen
        Debug.Log("int4 * int2 = " + result3);
        
        // %
        int result4 = myFirstInteger % mySecondInteger;
        Debug.Log("int4 % int2 = " + result4);
        
        

        // result = result + 1;
        //result += 1;
        result++;
        
        Debug.Log("result + 1 = " + result);
        
        // MyFirstFunction();// Hier rufen wir unsere erste eigene Funktion auf
        // es geht erst wieter, wenn die Funktion komplett abgeschlossen wurde
        
        Debug.Log("Start ist zu Ende");
        
    }
    

    // Update is called once per frame
    // void Update()
    // {
    //     //Debug.Log("Das Programm läuft");
    //     myCounterInteger++;
    //     Debug.Log("myCounterIntreger" + myCounterInteger);
    // }
    //unsere erste Funktion
    // Namen können wir frei aussuchen - sollte aber natürlich irgendwie die Funktion beschreiben
    // Funktionen werden großgeschrieben 
    
    // public, wenn sie von anderen scripts oder z.B. von Buttons mit verwendet werden soll 
    
  public void MyFirstFunction()
    {
       Debug.Log("meine Funktion wurde ausgeführt");
    }
}
