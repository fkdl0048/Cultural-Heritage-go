using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManger : PocketDroidsSceneManger  {
    private GameObject droid;
    private AsyncOperation loadScene;

    public override void droidTapped(GameObject droid)
    {

        List<GameObject> list = new List<GameObject>();
        list.Add(droid);
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_CAPTURE, list);
    }

    public override void playerTapped(GameObject player)
    {
        //추후에 추가 플레이어 텝
        //zoom 눌러서 현재 위치 크게 파악하기..
    }
}
