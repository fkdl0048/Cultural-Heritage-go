using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManger : PocketDroidsSceneManger {

    [SerializeField] private AudioClip yes;
    [SerializeField] private AudioClip no;

    private CaptureSceneStatus status = CaptureSceneStatus.InProgress;
    private AudioSource audio;


    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public CaptureSceneStatus Status {
        get { return status; }
    }

    public override void droidTapped(GameObject droid)
    {
        print("CaptureSceneManger.PlayerTapped activated");
    }

    public override void playerTapped(GameObject player)
    {
        print("CaptureSceneManger.droidTapped activated");
    }

    public void correct()
    {
        audio.PlayOneShot(yes);
        status = CaptureSceneStatus.Successful;
        GameManger.Instance.CurrentPlayer.AddDiscovered(1);
        GameManger.Instance.CurrentPlayer.Test = false;
        Invoke("MoveToWorldScene", 2.0f);
    }

    public void wrong()
    {
        audio.PlayOneShot(no);
        status = CaptureSceneStatus.Failed;
        Invoke("MoveToWorldScene", 2.0f);
    }

    private void MoveToWorldScene()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
