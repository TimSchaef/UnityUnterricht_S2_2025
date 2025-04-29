using System;
using System.Linq;
using MyBox;
using UnityEngine;

public class StringChecker : MonoBehaviour
{
   [SerializeField] private string unserName;
   [SerializeField] private string email;


   [ButtonMethod]
   void CheckStrings()
   {
    //username mind. 8 charakters
    
    
    // Sring.Length gibt die Länge eines Strings zurück (also die Anzahl der Characters)
    // string.ALL(Char.IsLetter) checkt, ob alle elemente Buchstaben sind
    if (unserName.Length >= 8 && unserName.Length <=15 && unserName.All(Char.IsLetter))
    { 
        Debug.Log("UserName akzeptiert");
    } 
    else
    {
        Debug.Log("Username muss mindestens 15 Buchstaben haben und es dürfen nur buchstaben enthalten sein");
    }
    //email muss @ enthalten, mindestens 10 zeichen haben
    //string.Contains('c') checkt, ob der charater 'c' in dem String enthalten ist 
    if (email.Length >= 10 && email.Contains('@'))
    { 
        Debug.Log("Email akzeptiert");
    } 
    else
    {
        Debug.Log("Email muss mindestens 10 Buchstaben haben und es muss ein @ enthalten sein");
    }
    
    
    
    
   }
   
   
   
}
