using UnityEngine;

public class ForceTest : MonoBehaviour
{
    public float jumpForce = 300f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Tác động một lực hướng lên trên tức thời (Impulse)
            rb.AddForce(Vector3.up * jumpForce); 
        }
    }
}