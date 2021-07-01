﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid : MonoBehaviour {

    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defense = 0;
    [SerializeField] private int hp = 10;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public float SpawnRateP {
        get { return spawnRate; }
    }

    public float CatchRate {
        get { return catchRate; }
    }

    public int Attack {
        get { return attack; }
    }

    public int Defense {
        get { return defense; }
    }

    public int Hp {
        get { return hp; }
    }

    private void OnMouseDown()
    {
        PocketDroidsSceneManger[] managers = FindObjectsOfType<PocketDroidsSceneManger>();
        foreach (PocketDroidsSceneManger pocketDroidsSceneManger in managers)
        {
            if (pocketDroidsSceneManger.gameObject.activeSelf)
            {
                pocketDroidsSceneManger.droidTapped(this.gameObject);
            }
        }
    }
}
