using UnityEngine;
using UnityEngine.InputSystem;

public class CreatingSimpleObjekts : MonoBehaviour
{
 [SerializeField] private float speed = 2f;
 [SerializeField] private float scale = 3f;
    private GameObject goSphere;
    private GameObject Sphere1;
    private GameObject Sphere2;
    private GameObject Sphere3;
    private GameObject Sphere4;
    
    
    Vector3 direction = new Vector3(3f, 1f);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
    {
      goSphere =  GameObject.CreatePrimitive(PrimitiveType.Sphere);
       Sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
       Sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
       Sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere); 
       Sphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);   
      
      goSphere.transform.position = new Vector2(2, 3);
      Sphere1.transform.position = goSphere.transform.position + new Vector3(1, 1, 0);
      Sphere2.transform.position = goSphere.transform.position + new Vector3(1, -1, 0);
      Sphere3.transform.position = goSphere.transform.position + new Vector3(-1, -1, 0);
      Sphere4.transform.position = goSphere.transform.position + new Vector3(-1, 1, 0);
      
      goSphere.transform.position = goSphere.transform.position + new Vector3(-4, 0);
    }
    void Update()
    {
        goSphere.transform.position = goSphere.transform.position + direction * Time.deltaTime * speed;

        float currentScale = goSphere.transform.localScale.x;
        
        Sphere1.transform.position = goSphere.transform.position + new Vector3(1, 1, 0) * currentScale; 
        Sphere2.transform.position = goSphere.transform.position + new Vector3(1, -1, 0) * currentScale;
        Sphere3.transform.position = goSphere.transform.position + new Vector3(-1, -1, 0) * currentScale;
        Sphere4.transform.position = goSphere.transform.position + new Vector3(-1, 1, 0) * currentScale;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            direction = -direction;
            Debug.Log("Space Key pressed, The new direction is" + direction);
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
         direction = new Vector3(0f, 1f);
         Debug.Log("W Key pressed, The new direction is Up"); 
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
         direction = new Vector3(0f, -1f);
         Debug.Log("S Key pressed, The new direction is Down"); 
        }
        
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
         direction = new Vector3(-1f, 0f);
         //direction = Vector3.right;
         Debug.Log("A Key pressed, The new direction is Left"); 
        }
        
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
         direction = new Vector3(1f, 0f);
         Debug.Log("D Key pressed, The new direction is Right"); 
        }
        
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
         goSphere.transform.localScale = Vector3.one * scale;
        }
        
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
         goSphere.transform.localScale = Vector3.zero * scale;
        }
        
        
    }
    

    
}
