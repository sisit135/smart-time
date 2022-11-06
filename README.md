# Smart Time ![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
<img align="right" width="160px" height="160px" src="/images/smart time main.png">
A convenient smart student time tracker system.

**Links:**

[Line (help & support)]()

[Documents](https://1drv.ms/f/s!AtKx-CQIOZgigdl63O22WuDOluoLzg)

[Discord](https://discord.gg/P7AStcdZGt) ![Discord Shield](https://discordapp.com/api/guilds/986609909233750076/widget.png?style=shield)

[Roadmap](https://trello.com/b/Ey8l51s7/smart-time)

<img align="center" src="/images/ui-prototype-1.png">


## History and intro
Smart time is a program in Windows PC that will help with issuing a time tracker for
students to go out during the class time it also has other useful features such as
auto sync which will automatically sync students who have permission as a list to
every computer with this program.

Currently, our system is available for access in desktop application and Line bot 
## 📂 Project structure

```
smart-time (repo root)
├── SmartTimeDesktop
│   ├── desktopInstaller - Source code of windows installer
│   ├── SICP-RS - Shared common code.
│   ├── SmartTime - Current desktop UI app.
│   └── SmartTime-oldui - The old desktop UI app.
├── smart-time-backend - backend services; responsible for student permissions cacheing and data provider.
└── smart-time-linebot - Line bot system; for both student and teacher services.  
```

## ⚒️ Development
//TODO

### 💻 Get up and running on your machine
Make sure to have git and dotnet 6 sdk installed on your machine. 
```console
git clone https://github.com/sisit135/smart-time.git
cd SmartTimeDesktop
dotnet run
```
Or alternatively, open in Visual studio then hit F5.

And enjoy.

## 📐 Desktop app UI design and implemention
Desktop app is writen in [C#10](https://www.blognone.com/node/125746) and dotnet 6.0 by me (SN).
illustration,Renders and Logo using [adobe software](https://en.wikipedia.org/wiki/Adobe_Inc.#Products) by [JonathanFake](https://github.com/JonathanFake)

### Technologies
UI is designed with [Material Design](https://material.io/design).

The application is implemented under [MVVM](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel), IOC, and [DI](https://en.wikipedia.org/wiki/Dependency_injection#C#) pattern.
