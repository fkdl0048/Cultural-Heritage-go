using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManger : Singleton<GameManger> {

    [SerializeField] private Player currentPlayer;

    public Player CurrentPlayer
    {
        get { return currentPlayer; }
    }

    private void Awake()
    {
        Assert.IsNotNull(CurrentPlayer);
    }
}
