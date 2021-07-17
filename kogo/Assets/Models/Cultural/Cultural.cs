using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Location;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class Cultural : MonoBehaviour {

    [SerializeField] private Vector2d pos; //테스트용 위치 표시
    [SerializeField] private AudioClip pickSound; //두루마리 클릭 사운드 

    private AbstractMap map;
    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Start () {
        map = LocationProviderFactory.Instance.mapManager;
        pos = new Vector2d(60.19188, 24.9685822);
        transform.localPosition = map.GeoToWorldPosition(pos);
    }

    private void OnMouseDown()
    {
        audio.PlayOneShot(pickSound);
    }

    private void OnCollisionEnter(Collision collision)
    {
        audio.PlayOneShot(pickSound);
        
    }

}
