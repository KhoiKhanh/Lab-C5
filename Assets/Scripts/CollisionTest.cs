using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Va chạm vật lý (Vật cản cứng)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm mạnh với: " + collision.gameObject.name);
        // Đổi màu để dễ nhìn
        GetComponent<SpriteRenderer>().color = Color.red; 
    }

    // Đi xuyên qua (Trigger zone)
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi xuyên qua vùng Trigger: " + other.gameObject.name);
        // Ví dụ: Ăn coin thì coin biến mất
        Destroy(other.gameObject); 
    }
}