﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWorld : MonoBehaviour {

    private void OnMouseDown()
    {
        Move();
    }

    public void Move()
    {
        SceneTransitionManager.Instance.GoToScene(PocketDroidsContants.SCENE_WORLD, new List<GameObject>());
    }
}
