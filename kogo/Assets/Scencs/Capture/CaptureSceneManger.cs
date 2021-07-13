using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManger : PocketDroidsSceneManger {

    [SerializeField] private int maxThrowAttempts = 3;
    [SerializeField] private GameObject orb;
    [SerializeField] private Vector3 spawnPoint;

    private int currentTrowAttempts;

    public int MaxThrowAttempts {
        get { return maxThrowAttempts; }
    }

    public int CurrentThrowAttempts
    {
        get { return currentTrowAttempts; }
    }

    private void Start()
    {
        CalculateMaxThrows();
        currentTrowAttempts = maxThrowAttempts;
    }

    private void CalculateMaxThrows()
    {
        //maxThrowAttempts += GameManger.Instance.CurrentPlayer.Lvl / 5;
    }

    public void OrbDestroyed()
    {
        currentTrowAttempts--;
        if (currentTrowAttempts <= 0)
        {

        }
        else {
            Instantiate(orb, spawnPoint, Quaternion.identity);
        }
    }

    public override void droidTapped(GameObject droid)
    {
        print("CaptureSceneManger.PlayerTapped activated");
    }

    public override void playerTapped(GameObject player)
    {
        print("CaptureSceneManger.droidTapped activated");
    }
}
