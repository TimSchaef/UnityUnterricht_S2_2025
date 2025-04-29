using MyBox;
using UnityEngine;

public class IfUNDelse : MonoBehaviour
{
    [SerializeField] private int numberInt;
    [SerializeField] private float numberFloat;
    
    
    
    [ButtonMethod]

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
            if ((numberInt > 5 && numberInt < 10) || numberInt == 20)
            {
                Debug.Log("Die Zahl ist größer als 5 und kleiner als 10 oder sie ist 20");
            }
            else
            {
                Debug.Log("Die Zahl ist nicht größer als 5.");
            }
            
            //als Ergebniss bekommen wir immer ein Boolean, den wir z.B. für ein if-Statement nutzen können
            //<   true wenn -> links ist größer als recht
            //>   true wenn -> rechts ist größer als liks
            //>=  true wenn -> links ist größer oer gleich als rechts
            //<=  true wenn -> rechts ist größer oder gleich als links
            //==  true wenn -> beide Seiten gleich sind
            //!=  true wenn -> beide Seiten NICHT gleich sind
            
            //Vooleans können kombiniert betrachtet werden
            //&& AND -> es müssen beide bools ture sein, damit es weiterhin true ist
            //|| OR  -> eine der beiden Booleans muss true sein, damit es weiterhin true ist
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Debug.Log("erste int-Zahl: " + numberInt);
        Debug.Log("erste float-Zahl" + numberFloat);
        
        
        //if 
       
        
            

            
        
    }
}
