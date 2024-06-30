using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static event Action<GameState> OnGameStateChanged;

    public GameState State;

    public int postersRippedTotal;

    public GameObject radio;

    void Start()
    {
        UpdateGameState(GameState.InBed);
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void PostersRipped()
    {
        postersRippedTotal = postersRippedTotal + 1;

        if (postersRippedTotal == 3)
        {
            UpdateGameState(GameState.PostersRipped);
            print("Posters destroyed.");
        }
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.InBed:
                break;
            case GameState.AlarmOff:
                break;
            case GameState.GotUpFrombed:
                break;
            case GameState.PostersRipped:
                radio.GetComponent<Radio>().enabled = true;
                break;
            case GameState.AllowedToLeaveApartment:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState
{
    InBed,
    AlarmOff,
    GotUpFrombed,
    PostersRipped,
    AllowedToLeaveApartment
}
