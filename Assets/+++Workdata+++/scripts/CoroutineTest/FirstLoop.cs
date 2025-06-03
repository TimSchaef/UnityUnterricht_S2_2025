using Unity.VisualScripting;
using UnityEngine;
using System.Collections;


public class FirstLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DelayLoop());

    }

    IEnumerator DelayLoop()
    {
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        
        
        for (int i = 0; i < 5; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.Rotate(0, 0, -6*i);
            cube.transform.position += new Vector3(i, 0, 0);
            
            
            Debug.Log("Loop " + i);  
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Schleife ist zu Ende");
    }

    
}





