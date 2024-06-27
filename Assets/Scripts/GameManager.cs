using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static event Action<GameState> OnGameStateChanged;

    public GameState State;

    void Start()
    {
        UpdateGameState(GameState.Sleeping);
    }

    void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Sleeping:
                break;
            case GameState.TurnAlarmOff:
                break;
            case GameState.WokenUp:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState
{
    Sleeping,
    TurnAlarmOff,
    WokenUp
}
