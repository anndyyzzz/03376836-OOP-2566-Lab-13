# 5.1
<img width="639" alt="Screenshot 2024-03-30 225649" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/ee43e24c-fb36-49ca-b222-876a01e23822">

# 5.2
<img width="641" alt="Screenshot 2024-03-30 225703" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/2e135e2f-15ed-4cea-b073-fb7a7cd6e836">

#### ในการทดลองนี้ เราสร้างอาร์เรย์ของอ็อบเจกต์ชนิด Animal และกำหนดค่าให้กับแต่ละอ็อบเจกต์ด้วยอ็อบเจกต์ของคลาส Dog, Bird, และ Fish ตามลำดับ จากนั้นเราทำการวนลูป foreach เพื่อเรียกใช้เมทอด Move() และ Speak() ของแต่ละอ็อบเจกต์ที่อยู่ในอาร์เรย์ โดยเมื่อเรียกใช้เมทอด Move() และ Speak() จะแสดงผลลัพธ์ตามลักษณะการเคลื่อนที่และการพูดของแต่ละสัตว์ ซึ่งถูกกำหนดไว้ในแต่ละคลาสที่สืบทอดจากคลาส Animal

#### โดย Dog, Bird, และ Fish มีการโอเวอร์ไรด์เมทอด Move() และ Speak() ที่ถูกกำหนดในอินเทอร์เฟซ IMovable และ ISpeakable และมีการประกาศเมทอด Move() และ Speak() ในคลาส Abstract Animal โดยให้เป็น abstract ซึ่งจะถูกโอเวอร์ไรด์ในคลาสที่สืบทอด และเราได้สร้าง Dog, Bird, และ Fish โดยการสืบทอดจากคลาส Abstract Animal และทำการโอเวอร์ไรด์เมทอด Move() และ Speak() ให้เหมาะสมกับลักษณะพฤติกรรมของแต่ละสัตว์ นอกจากนี้ เรายังเพิ่มการแสดงผลลัพธ์ของเมทอด Speak() ให้สอดคล้องกับลักษณะเสียงพูดของแต่ละสัตว์ที่เราสร้างขึ้นด้วย พร้อมกับการแสดงขีดคั่นหลังจากแต่ละการเรียกใช้เมทอด Move() และ Speak() เพื่อให้ผลลัพธ์มีความชัดเจนมากยิ่งขึ้น
