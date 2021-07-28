using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour {

    [SerializeField] private int discovered = 0;
    [SerializeField] private bool test;
    [SerializeField] private List<GameObject> droids = new List<GameObject>();

    private string path;

    public int Discovered
    {
        get { return discovered; }
    }

    public bool Test //삭제 테스트
    {
        get { return test; }
        set { test = value; }
    }

    public List<GameObject> Droids
    {
        get { return droids; }
    }


    private void Start()
    {
        path = Application.persistentDataPath + "/player2.dat";
        Load();
        test = true;
    }

    public void AddDiscovered(int discovered) //발견한 문화재로 수정
    {
        this.discovered += Mathf.Max(0, discovered);
        //InitLevelData();
        Save();
    }

    public void AddDroid(GameObject droid) //droid삭제
    {
        if (droid)
            droids.Add(droid);
        Save();
    }

    //private void InitLevelData() //해당 지역 문화재? 
    //{
    //    lvl = (xp / levelBase) + 1;
    //    requiredXp = levelBase * lvl;
    //}

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

            discovered = data.Discovered;
        }
        //else
        //{
        //    InitLevelData();
        //}
    }
}
