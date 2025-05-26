using UnityEngine;
using UnityEngine.InputSystem;

public class CharakterControllderSide : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumpForce = 10f;
    private float direction = 0f;

    private Rigidbody2D rb;

    [Header("GroundCheck")] [SerializeField]
    private LayerMask groundLayer;

    [SerializeField] private Transform transformfromGroundCheck;


    [Header("Manager")] [SerializeField] private CoinManager coinManager;
    [SerializeField] private UIManager uiManager;


    private bool canMove = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            direction = 0f;


            if (Keyboard.current.aKey.isPressed)
            {
                direction = -1;
            }

            if (Keyboard.current.dKey.isPressed)
            {
                direction = 1;
            }

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Jump();
            }

            rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        }
    }

    void Jump()
    {
        if (Physics2D.OverlapCircle(transformfromGroundCheck.position, 0.3f, groundLayer))
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wir sind mit etwas kollidiert");

        if (other.CompareTag("Coin"))
        {
            Debug.Log("Es war eine Münze");
            Destroy(other.gameObject);
            coinManager.AddCoin();
        }

        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Es war ein Obstacle");
            uiManager.ShowPanelLost();
            rb.linearVelocity = Vector2.zero;
            canMove = false;
        }
    }
}
