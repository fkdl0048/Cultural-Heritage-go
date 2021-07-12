using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPBonus : MonoBehaviour {

    [SerializeField] private int bonus = 10;

    private void OnMouseDown()
    {
        GameManger.Instance.CurrentPlayer.AddXp(bonus);
        Destroy(gameObject);
    }
}
