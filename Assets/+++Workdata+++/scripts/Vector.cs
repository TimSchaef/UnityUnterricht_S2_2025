using UnityEngine;

public class Vector : MonoBehaviour


{

    private Vector2 myFirstVector;
    private Vector2 mySecondVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myFirstVector = new Vector2(2, 3);
        mySecondVector = new Vector2(-3, 1);
        
        Vector2 vectorBetweenTwoVectors =  mySecondVector -myFirstVector; //wir könnenVektoren
                                                                          //addieren und Subtrahieren
                                                                          
                                                                          
       //den Vector zwischen den Punkten im Debug Log ausgeben
       
       Debug.Log(vectorBetweenTwoVectors);

       Vector2 reconstructMyFirstVector = mySecondVector - vectorBetweenTwoVectors;
       Vector2 reconstructMySecondVector = myFirstVector + vectorBetweenTwoVectors;
       
       Debug.Log(reconstructMyFirstVector);
       Debug.Log(reconstructMySecondVector);
    }
    
}
