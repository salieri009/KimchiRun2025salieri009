<div align="center">

![Header](https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=0,2,5,30&height=200&section=header&text=KimchiRun%202025&fontSize=60&fontColor=fff&animation=twinkling&desc=2D%20무한%20러닝%20게임&descAlign=50&descAlignY=65&descSize=25)

**기술적 우수성과 게임 개발 모범 사례의 만남**

![Unity](https://img.shields.io/badge/Unity-6.0-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-Educational-blue?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Mac%20%7C%20Linux-lightgrey?style=for-the-badge)

Language: [English](README.en.md) | [한국어](README.ko.md) | [日本語](README.ja.md)

---

</div>

## 📋 프로젝트 정보

**프로젝트 유형**: 2D 무한 러닝 게임  
**개발 플랫폼**: Unity 6  
**기술 스택**: C#, Unity Editor, Animator, Physics2D  
**기반**: 노마드 코더 김치런 튜토리얼  
**프로젝트 상태**: 30년차 엔지니어링 경험으로 리팩토링 완료

---

## 🚀 개요

KimchiRun 2025는 Unity 6로 제작된 프로덕션 수준의 2D 무한 러닝 게임입니다. 원래 노마드 코더 김치런 튜토리얼을 기반으로 하였으나, 이 프로젝트는 업계 모범 사례를 따라 완전히 리팩토링되어 깔끔한 아키텍처, 이벤트 기반 시스템, 프로덕션 수준의 코드 품질을 갖추고 있습니다.

### 주요 기능

* 🎮 **상태 관리**: 싱글톤 패턴을 활용한 견고한 게임 상태 시스템
* 🏃 **플레이어 컨트롤러**: 지면 감지 및 무적 시스템을 갖춘 고급 이동 시스템
* 🎯 **이벤트 시스템**: 이벤트 기반 아키텍처를 사용한 느슨한 결합 통신
* 🔧 **오브젝트 스포닝**: 전체 생명주기 제어가 가능한 코루틴 기반 스포너
* 🎨 **배경 스크롤**: 부드러운 무한 스크롤 배경
* ⚡ **성능 최적화**: 오브젝트 풀링 준비 완료, 효율적인 업데이트 루프
* 🛡️ **프로덕션 준비**: 포괄적인 null 체크, 오류 처리, 검증

---

## 🎥 데모 영상

<div align="center">

[![KimchiRun 2025 데모](https://img.youtube.com/vi/A58_FWqiekI/0.jpg)](https://www.youtube.com/watch?v=A58_FWqiekI)

**위 이미지를 클릭하여 게임플레이 데모를 시청하세요**

</div>

---

## 🎯 프로젝트 목표

* ✅ 완전히 작동하는 2D 무한 러닝 게임 구현
* ✅ Unity 게임 개발 모범 사례 시연
* ✅ 클린 코드 원칙 및 SOLID 설계 패턴 적용
* ✅ 유지보수 가능하고 확장 가능한 아키텍처 생성
* ✅ 느슨한 결합을 위한 이벤트 기반 시스템 구현
* ✅ 프로덕션 수준의 코드 품질 보장
* ✅ 포괄적인 XML 주석으로 코드 문서화

---

## 🏃 빠른 시작

### 사전 요구사항

* **Unity 6** 이상 설치
* **Visual Studio** 또는 **Rider** (C# 개발 권장)
* Unity 및 C# 기본 지식

### 설치 및 설정

1. **저장소 클론**
   ```bash
   git clone <repository-url>
   cd KimchiRun2025Salieri009
   ```

2. **Unity에서 열기**
   - Unity Hub 실행
   - 클론된 디렉토리에서 프로젝트 열기
   - Unity가 에셋을 가져올 때까지 대기

3. **게임 실행**
   - `Assets/Scenes/main.unity` 열기
   - Unity 에디터에서 Play 버튼 클릭
   - **Space** 키를 눌러 게임 시작

### 조작 방법

* **Space**: 점프 / 게임 시작

---

## 📁 프로젝트 구조

```
KimchiRun2025Salieri009/
├── Assets/
│   ├── Scripts/              # C# 게임 스크립트
│   │   ├── GameManager.cs    # 게임 상태 관리 (싱글톤)
│   │   ├── Player.cs         # 생명력 시스템을 갖춘 플레이어 컨트롤러
│   │   ├── Spawner.cs        # 오브젝트 스포너 (코루틴 기반)
│   │   ├── Mover.cs          # 이동 컴포넌트
│   │   ├── Destroyer.cs      # 오브젝트 정리 시스템
│   │   ├── BackGroundScroll.cs # 배경 스크롤
│   │   ├── GameConstants.cs  # 전역 상수
│   │   └── GameEvents.cs     # 이벤트 시스템
│   ├── Scenes/               # Unity 씬
│   │   └── main.unity        # 메인 게임 씬
│   ├── Prefabs/              # 게임 오브젝트 프리팹
│   ├── Animations/           # 애니메이션 컨트롤러
│   └── Sprites/              # 게임 스프라이트 및 텍스처
├── ProjectSettings/          # Unity 프로젝트 설정
└── README.md                 # 이 파일
```

---

## 🛠️ 기술 스택

### 핵심 기술

* **Unity 6**: 게임 엔진 및 에디터
* **C#**: 주요 프로그래밍 언어
* **Unity Physics2D**: 2D 물리 시스템
* **Unity Animator**: 애니메이션 상태 머신
* **Unity UI Toolkit**: 사용자 인터페이스 시스템

### 아키텍처 패턴

* **싱글톤 패턴**: 전역 접근을 위한 GameManager
* **이벤트 기반 아키텍처**: 느슨한 결합 컴포넌트 통신
* **컴포넌트 기반 설계**: 모듈화된 재사용 가능한 컴포넌트
* **MVC 유사 구조**: 관심사 분리
* **DAO 패턴**: 데이터 접근 추상화 (향후 확장 준비)

### 코드 품질

* **SOLID 원칙**: 코드베이스 전반에 적용
* **DRY (Don't Repeat Yourself)**: 중앙화된 상수 및 유틸리티
* **Null 안전성**: 포괄적인 null 체크 및 검증
* **오류 처리**: 적절한 예외 처리 및 로깅
* **문서화**: 모든 공개 API에 대한 XML 주석

---

## 📚 문서

<div align="center">

| 언어 | 문서 | 설명 |
|:----:|:----:|:----:|
| 🇺🇸 | [English](README.en.md) | 영어 전체 문서 |
| 🇰🇷 | [한국어](README.ko.md) | 한국어 전체 문서 |
| 🇯🇵 | [日本語](README.ja.md) | 일본어 전체 문서 |

</div>

---

## 🎨 코드 아키텍처

### 핵심 시스템

#### GameManager
* 싱글톤 패턴 구현
* 상태 관리 (MainMenu, InGame, GameOver)
* 이벤트 기반 상태 전환
* UI 및 스포너 생명주기 관리

#### Player Controller
* 지면 감지를 갖춘 고급 이동 시스템
* 생명력 관리 시스템
* 코루틴을 사용한 무적 시스템
* 상태 변경에 대한 이벤트 알림

#### Spawner System
* 코루틴 기반 스포닝
* 스폰 간 랜덤 지연
* Null 안전 프리팹 선택
* 시작/중지 제어 메서드

#### Event System
* 느슨한 결합 컴포넌트 통신
* 타입 안전 이벤트 알림
* 옵저버 패턴 구현

---

## 🔧 개발 가이드라인

### 코드 표준

* ✅ C# 명명 규칙 준수 (공개는 PascalCase, 비공개는 camelCase)
* ✅ 의미 있는 변수 및 메서드 이름 사용
* ✅ 적절한 오류 처리 구현
* ✅ 공개 API에 XML 주석 추가
* ✅ 일관된 코드 포맷팅 유지
* ✅ Unity Inspector 필드에 `[SerializeField]` 사용

### 모범 사례

* ✅ `Awake()`에서 모든 컴포넌트 참조 검증
* ✅ 더 나은 제어를 위해 `Invoke()` 대신 코루틴 사용
* ✅ 컴포넌트 접근 전 null 체크 구현
* ✅ 느슨한 결합 통신을 위해 이벤트 사용
* ✅ `GameConstants` 클래스에 상수 중앙화
* ✅ SOLID 원칙 준수

### 테스트

* ✅ 모든 게임 상태 및 전환 테스트
* ✅ 플레이어 이동 및 충돌 검증
* ✅ 스포너 기능 테스트
* ✅ 이벤트 시스템 검증
* ✅ 여러 화면 해상도에서 테스트

---

## 📖 주요 학습 포인트

* **🎮 게임 매니징**: 씬 전환, 게임 루프 관리, 오브젝트 생명주기
* **🧑‍💻 유저 인터랙션**: 키보드 입력 처리, 이벤트 시스템
* **🧩 UI 구성**: 버튼, 텍스트, 이미지 통합 및 애니메이션
* **🔁 게임 로직**: 충돌 감지, 점수 시스템, 난이도 조절
* **🏗️ 아키텍처**: 클린 코드, 설계 패턴, 유지보수 가능한 구조

---

## 🎯 개발 목표

이 프로젝트는 단순히 튜토리얼을 따라하는 것을 넘어서, **게임 로직을 직접 설계하고 수정하여** 고유한 게임으로 발전시키는 것을 목표로 합니다. Unity의 기본 기능부터 씬 구성, UI 설계, 게임 매니징까지 게임 개발 워크플로우의 전체적인 경험을 제공합니다.

---

## 📄 라이선스

이 프로젝트는 **교육 목적**으로 개발되었으며, 학습 여정의 일부입니다. 모든 코드와 문서는 교육적 사용 및 개인 개발을 위한 것입니다.

