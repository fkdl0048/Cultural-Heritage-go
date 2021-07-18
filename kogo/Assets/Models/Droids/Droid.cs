using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Droid : MonoBehaviour {

    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defense = 0;
    [SerializeField] private int hp = 10;
    [SerializeField] private AudioClip crySound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Assert.IsNotNull(audioSource);
        Assert.IsNotNull(crySound);
    }

    public float SpawnRate {
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

    public AudioClip CrySound
    {
        get { return crySound; }
    }

    private void OnMouseDown()
    {
        PocketDroidsSceneManger[] managers = FindObjectsOfType<PocketDroidsSceneManger>();
        audioSource.PlayOneShot(crySound);  
        foreach (PocketDroidsSceneManger pocketDroidsSceneManger in managers)
        {
            if (pocketDroidsSceneManger.gameObject.activeSelf)
            {
                pocketDroidsSceneManger.droidTapped(this.gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        PocketDroidsSceneManger[] managers = FindObjectsOfType<PocketDroidsSceneManger>();
        audioSource.PlayOneShot(crySound);
        foreach (PocketDroidsSceneManger pocketDroidsSceneManger in managers)
        {
            if (pocketDroidsSceneManger.gameObject.activeSelf)
            {
                pocketDroidsSceneManger.droidCollision(this.gameObject, collision);
            }
        }
    }
}
