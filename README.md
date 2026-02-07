# 🎮 Unity Physics Practice - Chapter 5

> **Môn học:** Lập trình Game
> 
> **Sinh viên:** Trần Khánh Khôi 

## 📖 Giới thiệu
Repository này chứa source code và scene thực hành chương 5 về hệ thống vật lý (Physics) trong Unity. Dự án bao gồm các bài Lab từ cơ bản đến nâng cao, xử lý va chạm trong môi trường 2D và 3D, Rigidbody, Physics Materials và Character Controller.

---

## 📂 Danh sách Lab thực hành

### 📌 Lab 1: Collider 2D Cơ bản
- **Mục tiêu:** Làm quen với các dạng hình học va chạm.
- **Triển khai:**
  - Setup `BoxCollider2D`, `CircleCollider2D`, `PolygonCollider2D` khớp với Sprite.
  - Kiểm tra vùng va chạm trong Scene view.

### 📌 Lab 2: Rigidbody 2D & Xử lý sự kiện
- **Mục tiêu:** Áp dụng trọng lực và bắt sự kiện va chạm.
- **Triển khai:**
  - Gắn `Rigidbody2D` cho Player.
  - Script `CollisionTest.cs`:
    - `OnCollisionEnter2D`: Xử lý va chạm cứng (đổi màu nhân vật).
    - `OnTriggerEnter2D`: Xử lý đi xuyên vật thể (ăn coin/vật phẩm).

### 📌 Lab 3: Physics Material 2D
- **Mục tiêu:** Giả lập chất liệu bề mặt.
- **Triển khai:**
  - Tạo Material **Bouncy** (Độ nảy cao) và **Slippery** (Ma sát = 0).
  - So sánh sự khác biệt khi Player rơi xuống các bề mặt khác nhau.

### 📌 Lab 4: Effector 2D
- **Mục tiêu:** Tạo cơ chế tương tác môi trường đặc biệt.
- **Triển khai:**
  - **PlatformEffector2D:** Tạo sàn một chiều (nhảy từ dưới lên).
  - **SurfaceEffector2D:** Tạo băng chuyền đẩy nhân vật trượt đi.

### 📌 Lab 5: Collider & Rigidbody 3D
- **Mục tiêu:** Chuyển đổi tư duy sang không gian 3D.
- **Triển khai:**
  - Setup môi trường 3D với Cube (Player) và Plane (Sàn).
  - Script `ForceTest.cs`: Sử dụng `Rigidbody.AddForce()` để tạo lực nhảy.

### 📌 Lab 6: Trigger vs Collision (3D)
- **Mục tiêu:** Phân biệt va chạm vật lý và vùng cảm ứng trong 3D.
- **Triển khai:**
  - So sánh `IsTrigger = true` (Ghost zone) và `false` (Wall).
  - Log debug để kiểm chứng `OnCollisionEnter` và `OnTriggerEnter`.

### 📌 Lab 7: Character Controller
- **Mục tiêu:** Điều khiển nhân vật không phụ thuộc hoàn toàn vào Physics engine.
- **Triển khai:**
  - Sử dụng component `Character Controller`.
  - Script `SimpleMoveController.cs`: Di chuyển mượt mà, leo dốc (`Slope Limit`) và bước qua bậc thang (`Step Offset`).

---

## 🧠 Tổng hợp kiến thức (Technical Notes)

### 1. Phân biệt Collision và Trigger

| Tính năng | Collision (Va chạm cứng) | Trigger (Vùng cảm ứng) |
| :--- | :--- | :--- |
| **Cài đặt** | `Is Trigger`: ⬜ Unchecked | `Is Trigger`: ✅ Checked |
| **Hiện tượng** | Vật thể bị chặn lại, nảy ra. | Vật thể đi xuyên qua nhau. |
| **Hàm 2D** | `OnCollisionEnter2D` | `OnTriggerEnter2D` |
| **Hàm 3D** | `OnCollisionEnter` | `OnTriggerEnter` |
| **Ứng dụng** | Tường, sàn, chướng ngại vật. | Checkpoint, vùng bẫy, nhặt vật phẩm. |

### 2. Các phương pháp di chuyển

- **Rigidbody.AddForce():** Tạo lực đẩy, có quán tính (giống thực tế: xe chạy, đạn bắn).
- **Rigidbody.velocity:** Gán vận tốc trực tiếp, kiểm soát hoàn toàn tốc độ (thường dùng cho 2D Platformer).
- **CharacterController.SimpleMove():** Dành cho nhân vật dạng người, tự động xử lý trọng lực và leo bậc thang, không bị nảy lung tung.

### 3. Lưu ý quan trọng
- **Không trộn lẫn:** Physics 2D (`Collider2D`) không tương tác với Physics 3D (`Collider`).
- **Tối ưu:** Các tác động vật lý nên được thực hiện trong hàm `FixedUpdate()` thay vì `Update()`.

---

## 🚀 Cài đặt & Chạy thử
1. Clone dự án:
   ```bash
   git clone [https://github.com/username/project-name.git](https://github.com/username/project-name.git)
