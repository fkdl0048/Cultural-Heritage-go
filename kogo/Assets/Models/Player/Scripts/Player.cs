﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour {

    [SerializeField] private int xp = 0;
    [SerializeField] private int requiredXp = 100;
    [SerializeField] private int levelBase = 100;
    [SerializeField] private List<GameObject> droids = new List<GameObject>();
    private int lvl = 1;

    private string path;

    public int Xp {
        get { return xp; }
    }

    public int RequiredXp {
        get { return requiredXp; }
    }

    public int LevelBase
    {
        get { return levelBase; }
    }

    public List<GameObject> Droids
    {
        get { return droids; }
    }

    public int Lvl {
        get { return lvl; }
    }

    private void Start()
    {
        path = Application.persistentDataPath + "/player.dat";
        Load();
    }

    public void AddXp(int xp) //발견한 문화재로 수정
    {
        this.xp += Mathf.Max(0, xp);
        InitLevelData();
        Save();
    }

    public void AddDroid(GameObject droid) //droid삭제
    {
        if(droid)
        droids.Add(droid);
        Save();
    }

    private void InitLevelData() //해당 지역 문화재? 
    {
        lvl = (xp / levelBase) + 1;
        requiredXp = levelBase * lvl;
    }

    //데이터 저장 구간
    private void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        PlayerData data = new PlayerData(this);
        bf.Serialize(file, data);
        file.Close();
    }

    private void Load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            xp = data.Xp;
            requiredXp = data.RequiredXp;
            levelBase = data.LevelBase;
            lvl = data.Lvl;

            //import player droids;
        }
        else
        {
            InitLevelData();
        }
    }
}
