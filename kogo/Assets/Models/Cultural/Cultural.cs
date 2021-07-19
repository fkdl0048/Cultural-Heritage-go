using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Location;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine.SceneManagement;

public class Cultural : MonoBehaviour {

    [SerializeField] private AudioClip pickSound; //오브젝트 클릭 사운드 

    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!GameManger.Instance.CurrentPlayer.Test)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        audio.PlayOneShot(pickSound);
        PocketDroidsSceneManger[] managers = FindObjectsOfType<PocketDroidsSceneManger>();
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
        audio.PlayOneShot(pickSound);
    }

}
