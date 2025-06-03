using UnityEngine;
using System.Collections;


public class FirstCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(ShowDebug()); 
       Debug.Log("In Start nach dem Call der Coroutine");
    }

    IEnumerator ShowDebug()
    {
        yield return null;  // warten für ein Frame
        yield return new WaitForSeconds(5f); // warten für 5 Sekunden
        Debug.Log("Function was called");
    }
}
