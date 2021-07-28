using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData {
    private int discovered;
    private List<DroidData> droids;

    public int Discovered { get { return discovered; } }
    public List<DroidData> Droids { get { return droids; } }

    public PlayerData(Player player)
    {
        discovered = player.Discovered;

        foreach (GameObject droidObject in player.Droids)
        {
            Droid droid = droidObject.GetComponent<Droid>();
            if (droid != null)
            {
                DroidData data = new DroidData(droid);
                droids.Add(data);
            }
        }
    }
}
