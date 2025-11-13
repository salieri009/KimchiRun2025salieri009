using UnityEngine;

public enum GameState
{
    MainMenu,
    InGame,
    GameOver
}

/// <summary>
/// 게임 상태 및 전역 게임플레이 관리
/// 싱글톤 패턴으로 구현하여 전역 접근 가능
/// </summary>
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    _instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return _instance;
        }
    }

    [SerializeField] private GameState _currentGameState = GameState.MainMenu;
    
    public GameState CurrentGameState
    {
        get => _currentGameState;
        private set
        {
            if (_currentGameState != value)
            {
                _currentGameState = value;
                GameEvents.NotifyGameStateChanged(value);
            }
        }
    }

    [Header("UI References")]
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _inGameUI;
    [SerializeField] private GameObject _gameOverUI;

    [Header("Spawner References")]
    [SerializeField] private GameObject _enemySpawner;
    [SerializeField] private GameObject _foodSpawner;
    [SerializeField] private GameObject _goldSpawner;
    [SerializeField] private GameObject _buildingSpawner;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        InitializeGame();
    }

    private void Update()
    {
        HandleInput();
    }

    private void InitializeGame()
    {
        SetGameState(GameState.MainMenu);
    }

    private void HandleInput()
    {
        if (CurrentGameState == GameState.MainMenu && 
            Input.GetKeyDown(GameConstants.START_GAME_KEY))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.InGame);
    }

    public void GameOver()
    {
        SetGameState(GameState.GameOver);
    }

    public void ReturnToMainMenu()
    {
        SetGameState(GameState.MainMenu);
    }

    private void SetGameState(GameState newState)
    {
        CurrentGameState = newState;
        
        // UI 상태 업데이트
        SetUIActive(_mainMenu, newState == GameState.MainMenu);
        SetUIActive(_inGameUI, newState == GameState.InGame);
        SetUIActive(_gameOverUI, newState == GameState.GameOver);
        
        // 스포너 활성화/비활성화
        bool isInGame = newState == GameState.InGame;
        SetSpawnerActive(_enemySpawner, isInGame);
        SetSpawnerActive(_foodSpawner, isInGame);
        SetSpawnerActive(_goldSpawner, isInGame);
        SetSpawnerActive(_buildingSpawner, isInGame);
    }

    private void SetUIActive(GameObject uiObject, bool active)
    {
        if (uiObject != null)
        {
            uiObject.SetActive(active);
        }
    }

    private void SetSpawnerActive(GameObject spawner, bool active)
    {
        if (spawner != null)
        {
            spawner.SetActive(active);
        }
    }

    private void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
