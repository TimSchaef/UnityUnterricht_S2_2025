using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class MostSimplecharakterscript : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    
    private Vector3 direction = new Vector3(0f, 0f);

    [SerializeField] private int countNumber = 0;
    [SerializeField] private TMP_Text countText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //_____________BEWEGUNG__________________
        transform.position += direction.normalized * speed * Time.deltaTime;
        direction = Vector3.zero;
        
        if (Keyboard.current.wKey.isPressed)
        {
            //direction = new Vector3(0f, 1f);
            direction.y = 1;
            Debug.Log("W Key pressed, The new direction is Up"); 
        }
        
        if (Keyboard.current.sKey.isPressed)
        {
            //direction = new Vector3(0f, -1f);
            direction.y = -1;
            Debug.Log("S Key pressed, The new direction is Down"); 
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            //direction = new Vector3(-1f, 0f);
            //direction = Vector3.right;
            direction.x = -1;
            Debug.Log("A Key pressed, The new direction is Left"); 
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            //direction = new Vector3(1f, 0f);
            direction.x= 1;
            Debug.Log("D Key pressed, The new direction is Right"); 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wir sind mit etwas kollidiert");

        if (other.CompareTag("Coin"))
        {
            Debug.Log("Es war eine Münze");
            Destroy(other.gameObject);
            countNumber++; 
        }
        
            
        
    }
}
