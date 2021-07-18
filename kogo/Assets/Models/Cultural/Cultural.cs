using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Location;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine.SceneManagement;

public class Cultural : MonoBehaviour {

    [SerializeField] private Vector2d pos; //테스트용 위치 표시
    [SerializeField] private AudioClip pickSound; //오브젝트 클릭 사운드 

    private AbstractMap map;
    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Start () {
        map = LocationProviderFactory.Instance.mapManager;
        pos = new Vector2d(60.19188, 24.9685822); //문화재 위도 경도_ 좌표 설정
        transform.localPosition = map.GeoToWorldPosition(pos);
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
