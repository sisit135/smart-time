# Smart Time ![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
<img align="right" width="160px" height="160px" src="/SmartTimeDesktop/SmartTime/Resources/smart_toilet_register.png">
A convenient smart student time tracker system.

**Links:**

[Line (help & support)]()

[Documents](https://1drv.ms/f/s!AtKx-CQIOZgigdl63O22WuDOluoLzg)

[Discords](https://discord.gg/P7AStcdZGt)

[Roadmap](https://trello.com/b/Ey8l51s7/smart-time)


## History and intro
Smart time is a program in Windows PC that will help with issuing a time tracker for
students to go out during the class time it also has other useful features such as
auto sync which will automatically sync students who have permission as a list to
every computer with this program.

Current our system is avilable for acess in desktop application and Line bot 
## 📂 Project structure

```
smart-time (repo root)
├── SmartTimeDesktop
│   ├── desktopInstaller - Source code of windows install
│   ├── SICP-RS - Shared common code.
│   ├── SmartTime - Current desktop UI app.
│   └── SmartTime-oldui - The old desktop UI app.
├── smart-time-backend - backend services; responsible for student permittions cacheing and data provider.
└── smart-time-linebot - Line bot system; for both student and teacher services.  
```

## ⚒️ Development

//TODO

### 💻 Get up and running on your machine

//TODO

## 📐 Desktop app UI design and implemention
Desktop app is writen in [C#10](https://www.blognone.com/node/125746) and dotnet 6.0 by me (SN).

UI is designed with [Material Design](https://material.io/design).

The application is implemented under [MVVM](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel), IOC, and [DI](https://en.wikipedia.org/wiki/Dependency_injection#C#) principle.
