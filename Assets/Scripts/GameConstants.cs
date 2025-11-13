using UnityEngine;

/// <summary>
/// 게임 전역 상수 및 설정값 관리
/// </summary>
public static class GameConstants
{
    // Tags
    public const string TAG_ENEMY = "Enemy";
    public const string TAG_FOOD = "food";
    public const string TAG_GOLDEN = "golden";
    public const string TAG_PLATFORM = "Platform";
    
    // Animation States
    public const int ANIM_STATE_IDLE = 0;
    public const int ANIM_STATE_JUMP = 1;
    public const int ANIM_STATE_LAND = 2;
    
    // Player Settings
    public const int MAX_LIVES = 3;
    public const float INVINCIBLE_DURATION = 5f;
    
    // Game Settings
    public const float DESTROY_X_THRESHOLD = -15f;
    public const KeyCode START_GAME_KEY = KeyCode.Space;
    public const KeyCode JUMP_KEY = KeyCode.Space;
}

