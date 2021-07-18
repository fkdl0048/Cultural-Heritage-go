using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManger : PocketDroidsSceneManger {

    [SerializeField] private Vector3 spawnPoint;

    private CaptureSceneStatus status = CaptureSceneStatus.InProgress;

    private void Start()
    {

    }

    public CaptureSceneStatus Status {
        get { return status; }
    }

    //Invoke("MoveToWorldScene", 2.0f);

    public override void droidTapped(GameObject droid)
    {
        print("CaptureSceneManger.PlayerTapped activated");
    }

    public override void playerTapped(GameObject player)
    {
        print("CaptureSceneManger.droidTapped activated");
    }

    public override void droidCollision(GameObject droid, Collision other)
    {
        status = CaptureSceneStatus.Successful;
        Invoke("MoveToWorldScene", 2.0f);
    }

    private void MoveToWorldScene()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
