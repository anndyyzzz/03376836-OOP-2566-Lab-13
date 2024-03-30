# 2.1
<img width="638" alt="Screenshot 2024-03-30 224825" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/da8ef0c2-bf18-4352-8b55-f921016a8def">

# 2.2
<img width="638" alt="Screenshot 2024-03-30 224836" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/8367d351-342d-4fd5-b3af-cf287e38d855">

#### ในการทดลองนี้ เราพยายามสร้างอาร์เรย์ของอ็อบเจกต์ชนิด IMovable แต่กำหนดให้ตัวแปรเป็นชนิด Animal[] ซึ่งเป็นคลาสที่มีการสืบทอดจาก IMovable ซึ่งไม่สามารถทำได้ ทำให้โค้ดไม่สามารถคอมไพล์ได้

#### นอกจากนี้ การวนลูป foreach จะเรียกใช้เมทอด Move() จากอาร์เรย์ animals ซึ่งถูกกำหนดให้เป็นชนิด IMovable[] ซึ่งไม่สามารถเข้าถึงเมทอด Move() ที่เป็น abstract ของคลาส Animal ได้

#### ดังนั้น เพื่อให้โค้ดสามารถรันได้ เราควรเปลี่ยนชนิดของอาร์เรย์ animals เป็น Animal[] และการสร้างอ็อบเจกต์ให้เป็นชนิด Animal ด้วย หรือจะใช้ IMovable[] ก็ต้องสร้างเมทอด Move() ในคลาส Animal ด้วย