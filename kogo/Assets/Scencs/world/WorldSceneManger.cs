using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManger : PocketDroidsSceneManger  {

    public override void droidTapped(GameObject droid)
    {
        SceneManager.LoadScene(PocketDroidsContants.SCENE_CAPTURE, LoadSceneMode.Additive);
    }

    public override void playerTapped(GameObject player)
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
