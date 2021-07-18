using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
