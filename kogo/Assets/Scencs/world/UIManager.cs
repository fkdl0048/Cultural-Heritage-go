﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class UIManager : MonoBehaviour {

    [SerializeField] private Text xpText;
    [SerializeField] private Text levelText;
    [SerializeField] private GameObject menu;

    private void Awake()
    {
        Assert.IsNotNull(xpText);
        Assert.IsNotNull(levelText);
        Assert.IsNotNull(menu);
    }

    public void updateLevel(int level)
    {
        levelText.text = level.ToString();
    }

    public void updateXP(int currentXP, int requiredXP)
    {
        xpText.text = currentXP.ToString() + " / " + requiredXP.ToString();
    }

    public void togleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }
}