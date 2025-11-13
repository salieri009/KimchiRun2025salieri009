<div align="center">

# 🎮 KimchiRun 2025

**Technical Excellence Meets Game Development Best Practices**

Language: [English](README.en.md) | [한국어](README.ko.md) | [日本語](README.ja.md)

---

</div>

## 📋 Project Information

**Project Type**: 2D Endless Runner Game  
**Development Platform**: Unity 6  
**Tech Stack**: C#, Unity Editor, Animator, Physics2D  
**Based On**: Nomad Coders KimchiRun Tutorial  
**Project Status**: Refactored with 30+ Years of Engineering Experience

---

## 🚀 Overview

KimchiRun 2025 is a professional-grade 2D endless runner game built with Unity 6. Originally based on the Nomad Coders KimchiRun tutorial, this project has been completely refactored following industry best practices, featuring clean architecture, event-driven systems, and production-ready code quality.

### Key Features

* 🎮 **State Management**: Robust game state system with singleton pattern
* 🏃 **Player Controller**: Advanced movement with ground detection and invincibility
* 🎯 **Event System**: Decoupled communication using event-driven architecture
* 🔧 **Object Spawning**: Coroutine-based spawner with full lifecycle control
* 🎨 **Background Scrolling**: Smooth infinite scrolling background
* ⚡ **Performance Optimized**: Object pooling ready, efficient update loops
* 🛡️ **Production Ready**: Comprehensive null checks, error handling, validation

---

## 🎥 Demo Video

<div align="center">

[![KimchiRun 2025 Demo](https://img.youtube.com/vi/A58_FWqiekI/0.jpg)](https://www.youtube.com/watch?v=A58_FWqiekI)

**Click the image above to watch the gameplay demo**

</div>

---

## 🎯 Project Objectives

* ✅ Implement a fully functional 2D endless runner game
* ✅ Demonstrate Unity game development best practices
* ✅ Apply clean code principles and SOLID design patterns
* ✅ Create maintainable and extensible architecture
* ✅ Implement event-driven systems for loose coupling
* ✅ Ensure production-ready code quality
* ✅ Document code with comprehensive XML comments

---

## 🏃 Quick Start

### Prerequisites

* **Unity 6** or higher installed
* **Visual Studio** or **Rider** (recommended for C# development)
* Basic knowledge of Unity and C#

### Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd KimchiRun2025Salieri009
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Open project from the cloned directory
   - Wait for Unity to import assets

3. **Run the Game**
   - Open `Assets/Scenes/main.unity`
   - Press Play in Unity Editor
   - Press **Space** to start the game

### Controls

* **Space**: Jump / Start Game

---

## 📁 Project Structure

```
KimchiRun2025Salieri009/
├── Assets/
│   ├── Scripts/              # C# Game Scripts
│   │   ├── GameManager.cs    # Game state management (Singleton)
│   │   ├── Player.cs         # Player controller with health system
│   │   ├── Spawner.cs        # Object spawner (Coroutine-based)
│   │   ├── Mover.cs          # Movement component
│   │   ├── Destroyer.cs      # Object cleanup system
│   │   ├── BackGroundScroll.cs # Background scrolling
│   │   ├── GameConstants.cs  # Global constants
│   │   └── GameEvents.cs     # Event system
│   ├── Scenes/               # Unity scenes
│   │   └── main.unity        # Main game scene
│   ├── Prefabs/              # Game object prefabs
│   ├── Animations/           # Animation controllers
│   └── Sprites/              # Game sprites and textures
├── ProjectSettings/          # Unity project settings
└── README.md                 # This file
```

---

## 🛠️ Tech Stack

### Core Technologies

* **Unity 6**: Game engine and editor
* **C#**: Primary programming language
* **Unity Physics2D**: 2D physics system
* **Unity Animator**: Animation state machine
* **Unity UI Toolkit**: User interface system

### Architecture Patterns

* **Singleton Pattern**: GameManager for global access
* **Event-Driven Architecture**: Decoupled component communication
* **Component-Based Design**: Modular, reusable components
* **MVC-like Structure**: Separation of concerns
* **DAO Pattern**: Data access abstraction (ready for future expansion)

### Code Quality

* **SOLID Principles**: Applied throughout the codebase
* **DRY (Don't Repeat Yourself)**: Centralized constants and utilities
* **Null Safety**: Comprehensive null checks and validation
* **Error Handling**: Proper exception handling and logging
* **Documentation**: XML comments for all public APIs

---

## 📚 Documentation

<div align="center">

| Language | Documentation | Description |
|:--------:|:-------------:|:-----------:|
| 🇺🇸 | [English](README.en.md) | Full documentation in English |
| 🇰🇷 | [한국어](README.ko.md) | 한국어 전체 문서 |
| 🇯🇵 | [日本語](README.ja.md) | 日本語完全ドキュメント |

</div>

---

## 🎨 Code Architecture

### Core Systems

#### GameManager
* Singleton pattern implementation
* State management (MainMenu, InGame, GameOver)
* Event-driven state transitions
* UI and spawner lifecycle management

#### Player Controller
* Advanced movement with ground detection
* Health system with lives management
* Invincibility system with coroutines
* Event notifications for state changes

#### Spawner System
* Coroutine-based spawning
* Random delay between spawns
* Null-safe prefab selection
* Start/Stop control methods

#### Event System
* Decoupled component communication
* Type-safe event notifications
* Observer pattern implementation

---

## 🔧 Development Guidelines

### Code Standards

* ✅ Follow C# naming conventions (PascalCase for public, camelCase for private)
* ✅ Use meaningful variable and method names
* ✅ Implement proper error handling
* ✅ Add XML comments for public APIs
* ✅ Maintain consistent code formatting
* ✅ Use `[SerializeField]` for Unity Inspector fields

### Best Practices

* ✅ Validate all component references in `Awake()`
* ✅ Use coroutines instead of `Invoke()` for better control
* ✅ Implement null checks before accessing components
* ✅ Use events for decoupled communication
* ✅ Centralize constants in `GameConstants` class
* ✅ Follow SOLID principles

### Testing

* ✅ Test all game states and transitions
* ✅ Verify player movement and collision
* ✅ Test spawner functionality
* ✅ Validate event system
* ✅ Test on multiple screen resolutions

---

## 📖 Key Learning Points

* **🎮 Game Management**: Scene transitions, game loop management, object lifecycle
* **🧑‍💻 User Interaction**: Keyboard input handling, event systems
* **🧩 UI Composition**: Button, text, image integration with animations
* **🔁 Game Logic**: Collision detection, scoring systems, difficulty adjustment
* **🏗️ Architecture**: Clean code, design patterns, maintainable structure

---

## 🎯 Development Goals

This project goes beyond simply following a tutorial. The goal is to **design and modify game logic directly**, evolving it into a unique game. From Unity's basic features to scene composition, UI design, and game management, this project provides a comprehensive experience in the entire game development workflow.

---

## 📄 License

This project is developed for **educational purposes** as part of a learning journey. All code and documentation are intended for educational use and personal development.

---

<div align="center">

**Built with ❤️ for Game Developers**

*Refactored with 30+ Years of Software Engineering Experience*

</div>

