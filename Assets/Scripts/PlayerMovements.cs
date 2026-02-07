using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Cài đặt tốc độ")]
    public float moveSpeed = 5f;    // Tốc độ chạy
    public float jumpForce = 10f;   // Lực nhảy

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        // Lấy component Rigidbody2D gắn trên Player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Nhận input từ bàn phím (Mũi tên trái/phải hoặc A/D)
        // GetAxisRaw trả về -1, 0 hoặc 1 (giúp nhân vật dừng ngay lập tức khi thả phím)
        moveInput = Input.GetAxisRaw("Horizontal");

        // 2. Xử lý nhảy (Phím Space)
        // Chỉ cho nhảy khi vận tốc Y gần bằng 0 (đang đứng trên sàn)
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        // 3. Di chuyển nhân vật (Thay đổi vận tốc theo trục X)
        // Giữ nguyên vận tốc Y để trọng lực hoạt động bình thường
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}