<div align="center">

![Header](https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=0,2,5,30&height=200&section=header&text=KimchiRun%202025&fontSize=60&fontColor=fff&animation=twinkling&desc=2D%20エンドレスランナーゲーム&descAlign=50&descAlignY=65&descSize=25)

**技術的卓越性とゲーム開発のベストプラクティスの出会い**

![Unity](https://img.shields.io/badge/Unity-6.0-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-Educational-blue?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Mac%20%7C%20Linux-lightgrey?style=for-the-badge)

Language: [English](README.en.md) | [한국어](README.ko.md) | [日本語](README.ja.md)

---

</div>

## 📋 プロジェクト情報

**プロジェクトタイプ**: 2Dエンドレスランナーゲーム  
**開発プラットフォーム**: Unity 6  
**技術スタック**: C#, Unity Editor, Animator, Physics2D  
**基盤**: Nomad Coders KimchiRunチュートリアル  
**プロジェクト状態**: 30年のエンジニアリング経験でリファクタリング完了

---

## 🚀 概要

KimchiRun 2025は、Unity 6で構築されたプロダクションレベルの2Dエンドレスランナーゲームです。元々Nomad Coders KimchiRunチュートリアルを基にしていましたが、このプロジェクトは業界のベストプラクティスに従って完全にリファクタリングされ、クリーンなアーキテクチャ、イベント駆動システム、プロダクションレベルのコード品質を備えています。

### 主な機能

* 🎮 **状態管理**: シングルトンパターンを活用した堅牢なゲーム状態システム
* 🏃 **プレイヤーコントローラー**: 地面検出と無敵システムを備えた高度な移動システム
* 🎯 **イベントシステム**: イベント駆動アーキテクチャを使用した疎結合通信
* 🔧 **オブジェクトスポーン**: 完全なライフサイクル制御が可能なコルーチンベースのスポーナー
* 🎨 **背景スクロール**: 滑らかな無限スクロール背景
* ⚡ **パフォーマンス最適化**: オブジェクトプーリング準備完了、効率的な更新ループ
* 🛡️ **プロダクション準備**: 包括的なnullチェック、エラーハンドリング、検証

---

## 🎥 デモ動画

<div align="center">

[![KimchiRun 2025 デモ](https://img.youtube.com/vi/A58_FWqiekI/0.jpg)](https://www.youtube.com/watch?v=A58_FWqiekI)

**上記の画像をクリックしてゲームプレイデモをご覧ください**

</div>

---

## 🎯 プロジェクト目標

* ✅ 完全に機能する2Dエンドレスランナーゲームの実装
* ✅ Unityゲーム開発のベストプラクティスの実演
* ✅ クリーンコード原則とSOLID設計パターンの適用
* ✅ 保守可能で拡張可能なアーキテクチャの作成
* ✅ 疎結合のためのイベント駆動システムの実装
* ✅ プロダクションレベルのコード品質の確保
* ✅ 包括的なXMLコメントによるコード文書化

---

## 🏃 クイックスタート

### 前提条件

* **Unity 6**以上がインストールされていること
* **Visual Studio**または**Rider**（C#開発推奨）
* UnityとC#の基本的な知識

### インストールとセットアップ

1. **リポジトリのクローン**
   ```bash
   git clone <repository-url>
   cd KimchiRun2025Salieri009
   ```

2. **Unityで開く**
   - Unity Hubを起動
   - クローンしたディレクトリからプロジェクトを開く
   - Unityがアセットをインポートするまで待機

3. **ゲームの実行**
   - `Assets/Scenes/main.unity`を開く
   - UnityエディタでPlayボタンをクリック
   - **Space**キーを押してゲームを開始

### 操作方法

* **Space**: ジャンプ / ゲーム開始

---

## 📁 プロジェクト構造

```
KimchiRun2025Salieri009/
├── Assets/
│   ├── Scripts/              # C#ゲームスクリプト
│   │   ├── GameManager.cs    # ゲーム状態管理（シングルトン）
│   │   ├── Player.cs         # ヘルスシステムを備えたプレイヤーコントローラー
│   │   ├── Spawner.cs        # オブジェクトスポーナー（コルーチンベース）
│   │   ├── Mover.cs          # 移動コンポーネント
│   │   ├── Destroyer.cs      # オブジェクトクリーンアップシステム
│   │   ├── BackGroundScroll.cs # 背景スクロール
│   │   ├── GameConstants.cs  # グローバル定数
│   │   └── GameEvents.cs     # イベントシステム
│   ├── Scenes/               # Unityシーン
│   │   └── main.unity        # メインゲームシーン
│   ├── Prefabs/              # ゲームオブジェクトプレハブ
│   ├── Animations/           # アニメーションコントローラー
│   └── Sprites/              # ゲームスプライトとテクスチャ
├── ProjectSettings/          # Unityプロジェクト設定
└── README.md                 # このファイル
```

---

## 🛠️ 技術スタック

### コア技術

* **Unity 6**: ゲームエンジンとエディタ
* **C#**: 主要プログラミング言語
* **Unity Physics2D**: 2D物理システム
* **Unity Animator**: アニメーション状態マシン
* **Unity UI Toolkit**: ユーザーインターフェースシステム

### アーキテクチャパターン

* **シングルトンパターン**: グローバルアクセスのためのGameManager
* **イベント駆動アーキテクチャ**: 疎結合コンポーネント通信
* **コンポーネントベース設計**: モジュール化された再利用可能なコンポーネント
* **MVC風構造**: 関心の分離
* **DAOパターン**: データアクセス抽象化（将来の拡張準備済み）

### コード品質

* **SOLID原則**: コードベース全体に適用
* **DRY (Don't Repeat Yourself)**: 中央集約された定数とユーティリティ
* **Null安全性**: 包括的なnullチェックと検証
* **エラーハンドリング**: 適切な例外処理とロギング
* **文書化**: すべての公開APIに対するXMLコメント

---

## 📚 ドキュメント

<div align="center">

| 言語 | ドキュメント | 説明 |
|:----:|:------------:|:----:|
| 🇺🇸 | [English](README.en.md) | 英語完全ドキュメント |
| 🇰🇷 | [한국어](README.ko.md) | 韓国語完全ドキュメント |
| 🇯🇵 | [日本語](README.ja.md) | 日本語完全ドキュメント |

</div>

---

## 🎨 コードアーキテクチャ

### コアシステム

#### GameManager
* シングルトンパターンの実装
* 状態管理（MainMenu, InGame, GameOver）
* イベント駆動状態遷移
* UIとスポーナーのライフサイクル管理

#### Player Controller
* 地面検出を備えた高度な移動システム
* ライフ管理システム
* コルーチンを使用した無敵システム
* 状態変更に対するイベント通知

#### Spawner System
* コルーチンベースのスポーン
* スポーン間のランダム遅延
* Null安全プレハブ選択
* 開始/停止制御メソッド

#### Event System
* 疎結合コンポーネント通信
* 型安全イベント通知
* オブザーバーパターンの実装

---

## 🔧 開発ガイドライン

### コード標準

* ✅ C#命名規則に従う（公開はPascalCase、非公開はcamelCase）
* ✅ 意味のある変数名とメソッド名を使用
* ✅ 適切なエラーハンドリングを実装
* ✅ 公開APIにXMLコメントを追加
* ✅ 一貫したコードフォーマットを維持
* ✅ Unity Inspectorフィールドに`[SerializeField]`を使用

### ベストプラクティス

* ✅ `Awake()`ですべてのコンポーネント参照を検証
* ✅ より良い制御のために`Invoke()`の代わりにコルーチンを使用
* ✅ コンポーネントアクセス前にnullチェックを実装
* ✅ 疎結合通信のためにイベントを使用
* ✅ `GameConstants`クラスに定数を中央集約
* ✅ SOLID原則に従う

### テスト

* ✅ すべてのゲーム状態と遷移をテスト
* ✅ プレイヤーの移動と衝突を検証
* ✅ スポーナー機能をテスト
* ✅ イベントシステムを検証
* ✅ 複数の画面解像度でテスト

---

## 📖 主な学習ポイント

* **🎮 ゲーム管理**: シーン遷移、ゲームループ管理、オブジェクトライフサイクル
* **🧑‍💻 ユーザーインタラクション**: キーボード入力処理、イベントシステム
* **🧩 UI構成**: ボタン、テキスト、画像の統合とアニメーション
* **🔁 ゲームロジック**: 衝突検出、スコアリングシステム、難易度調整
* **🏗️ アーキテクチャ**: クリーンコード、設計パターン、保守可能な構造

---

## 🎯 開発目標

このプロジェクトは、単にチュートリアルに従うことを超えて、**ゲームロジックを直接設計し修正し**、独自のゲームに進化させることを目標としています。Unityの基本機能からシーン構成、UI設計、ゲーム管理まで、ゲーム開発ワークフロー全体の包括的な経験を提供します。

---

## 📄 ライセンス

このプロジェクトは、学習の旅の一部として**教育目的**で開発されています。すべてのコードとドキュメントは、教育的使用と個人開発を目的としています。

