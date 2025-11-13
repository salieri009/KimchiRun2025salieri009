using System;
using UnityEngine;

/// <summary>
/// 게임 이벤트 시스템 - 느슨한 결합을 위한 이벤트 기반 통신
/// </summary>
public static class GameEvents
{
    public static event Action<GameState> OnGameStateChanged;
    public static event Action<int> OnPlayerLivesChanged;
    public static event Action OnPlayerDied;
    public static event Action OnPlayerHealed;
    public static event Action OnPlayerInvincibleStarted;
    public static event Action OnPlayerInvincibleEnded;
    
    public static void NotifyGameStateChanged(GameState newState)
    {
        OnGameStateChanged?.Invoke(newState);
    }
    
    public static void NotifyPlayerLivesChanged(int lives)
    {
        OnPlayerLivesChanged?.Invoke(lives);
    }
    
    public static void NotifyPlayerDied()
    {
        OnPlayerDied?.Invoke();
    }
    
    public static void NotifyPlayerHealed()
    {
        OnPlayerHealed?.Invoke();
    }
    
    public static void NotifyPlayerInvincibleStarted()
    {
        OnPlayerInvincibleStarted?.Invoke();
    }
    
    public static void NotifyPlayerInvincibleEnded()
    {
        OnPlayerInvincibleEnded?.Invoke();
    }
}

