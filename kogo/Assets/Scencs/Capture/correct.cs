using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correct : MonoBehaviour {

    [SerializeField] private GameObject successScreen;

    public void Btn()
    {
        successScreen.SetActive(false);
        Invoke("Move", 2.0f);
        
    }

    public void Move()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
