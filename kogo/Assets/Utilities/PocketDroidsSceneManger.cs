using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PocketDroidsSceneManger : MonoBehaviour {

    public abstract void playerTapped(GameObject player);
    public abstract void droidTapped(GameObject droid);

    public virtual void droidCollision(GameObject droid, Collision other) {}
}
 