using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManger : PocketDroidsSceneManger {

    private CaptureSceneStatus status = CaptureSceneStatus.InProgress;

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
        status = CaptureSceneStatus.Successful;
        Invoke("MoveToWorldScene", 2.0f);
    }

    public void wrong()
    {
        status = CaptureSceneStatus.Failed;
        Invoke("MoveToWorldScene", 2.0f);
    }

    private void MoveToWorldScene()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
