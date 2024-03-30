# 6.1
<img width="639" alt="Screenshot 2024-03-30 230009" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/982fddd0-0266-4b0c-8531-c922c7fb30a5">

# 6.2
<img width="639" alt="Screenshot 2024-03-30 230021" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-13/assets/144866059/dffbcee0-d0bd-41bc-92eb-2c43a9f697e3">

- สร้างอินสแตนซ์ของ SonyTV และ DesktopLamp และให้การทำงานต่าง ๆ เช่น เปิด/ปิด และการเปลี่ยนช่องสัญญาณ
- สร้าง Interface ชื่อ IRemoteControl ที่ประกอบด้วยเมทอด TurnOn, TurnOff, ChannelUp, และ ChannelDown ซึ่งเป็นเมทอดที่เกี่ยวกับการควบคุมอุปกรณ์รีโมทคอนโทรล
- สร้างคลาส PowerAppliance ซึ่งประกอบด้วยสถานะของพลังงาน (PowerStatus) และกำลังไฟ (Wattage)
- คลาส Television และ Lamp เป็นคลาสที่สืบทอดจาก PowerAppliance และ IRemoteControl โดยมีเมทอดเฉพาะที่ใช้สำหรับควบคุมทีวีและโคมไฟ
- คลาส SonyTV และ DesktopLamp ถูกสร้างเพื่อสืบทอดคุณสมบัติของทีวีและโคมไฟ โดยมีการโอเวอร์ไรด์เมทอดที่เป็นส่วนของ IRemoteControl ที่ให้การทำงานที่เหมาะสมสำหรับแต่ละอุปกรณ์
- ในการทดสอบ ได้ทดสอบการใช้งานของทีวีและโคมไฟ ด้วยการเรียกใช้เมทอดต่าง ๆ ที่ถูกสร้างขึ้น โดยทำให้แต่ละอุปกรณ์มีพฤติกรรมการทำงานที่แตกต่างกันไป
