# Smart Time ![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
<img align="right" width="160px" height="160px" src="/SmartTimeDesktop/SmartTime/Resources/smart_toilet_register.png">
ระบบติดตามเวลานักเรียนที่ใช้งานง่ายและสะดวก

**Links:**

[กลุ่มไลน์]()

[เอกสาร](https://1drv.ms/f/s!AtKx-CQIOZgigdl63O22WuDOluoLzg)

[ดีสคอร์ด](https://discord.gg/P7AStcdZGt) ![Discord Shield](https://discordapp.com/api/guilds/986609909233750076/widget.png?style=shield)

[เป้าหมายการพัฒนาในอนาคต](https://trello.com/b/Ey8l51s7/smart-time)

<img align="center" src="/images/ui-prototype-1.png">


## ประวัติและบทนำ
Smart time เป็นโปรแกรมใน Windows PC ที่จะช่วยติดตำมเวลำ ให้นักเรียนที่ออกไประหว่ำงเรียน และยังมีฟีเจอร์ที่เป็นประโยชน์อื่นๆ เช่น Auto Sync ซึ่งจะซิงค์นักเรียนที่ได้รับอนุญำตโดยอัตโนมัติให้เป็นรำยชื่อให้กับคอมพิวเตอร์ทุกเครื่องที่มีโปรแกรมนี้

ณ ขณะนี้ระบบของเรามีให้ใช้งานในแอปพลิเคชั่นเดสก์ท็อปและไลน์
## 📂 โครงสร้าง Repository นี้

```
smart-time (repo root)
├── SmartTimeDesktop
│   ├── desktopInstaller - รหัสต้นฉบับของติดตั้งในวินโดวส์
│   ├── SICP-RS - รหัสต้นฉบับที่ใช่ร่วมกันระหว่างโปรเจค
│   ├── SmartTime - รหัสต้นฉบับของแอปพลิเคชั่นเดสก์ท็อป
│   └── SmartTime-oldui - รหัสต้นฉบับเก่าของแอปพลิเคชั่นเดสก์ท็อป
├── smart-time-backend - ระบบใน server มีหน้าที่ในการเก็บข้อมูลและประมวลผล
└── smart-time-linebot - รหัสต้นฉบับของบอตไลน์
```

## ⚒️ การพัฒนาระบบ

### 💻 เตรียมและรันรหัสต้นฉบับในเครื่องของคุณ
โปรดแน่ใจว่าเครื่องของคุณใด้ติดตั้ง git กับ dotnet 6 sdk ไว้เรียบร้อยแล้ว
```console
git clone https://github.com/sisit135/smart-time.git
cd SmartTimeDesktop
dotnet run
```
หรือไม่เช่นนั้นให้เปิดให้ Visual studio แล้วกด F5

## 📐 Desktop app UI design and implemention
Desktop app is writen in [C#10](https://www.blognone.com/node/125746) and dotnet 6.0 by me (SN).

UI is designed with [Material Design](https://material.io/design).

The application is implemented under [MVVM](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel), IOC, and [DI](https://en.wikipedia.org/wiki/Dependency_injection#C#) principle.
