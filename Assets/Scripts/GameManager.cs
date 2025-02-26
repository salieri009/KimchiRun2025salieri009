using UnityEngine;

public enum GameState
{
    MainMenu,
    InGame,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public static GameState state;
    public static GameManager instance;

    public GameState CurrentGameState = GameState.MainMenu;

    [Header("References")]

    public GameObject MainMenu;
    public GameObject InGame;
    public GameObject GameOver;
    public GameObject EnemySpawner;
    public GameObject FoodSpawner;
    public GameObject GoldSpawner;
    public GameObject BuildingSpawner;
    private void Awake()
    {
        if(instance = null)
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       MainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(state == GameState.MainMenu && Input.GetKeyDown(KeyCode.Space))
        {
            state = GameState.InGame;
            MainMenu.SetActive(false);
            EnemySpawner.SetActive(true);
            FoodSpawner.SetActive(true);
            GoldSpawner.SetActive(true);
            BuildingSpawner.SetActive(true);
        }
    }
}
