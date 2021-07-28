using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class UIManager : MonoBehaviour {

    [SerializeField] private Text discovered; //xp
    //[SerializeField] private GameObject menu;
    [SerializeField] private AudioClip menuBtnSound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        Assert.IsNotNull(audioSource);
        Assert.IsNotNull(discovered);
        //Assert.IsNotNull(menu);
        Assert.IsNotNull(menuBtnSound);
    }

    private void Update()
    {
        //updateLevel();
        updatediscovered();
    }

    public void updatediscovered()
    {
        discovered.text = GameManger.Instance.CurrentPlayer.Discovered.ToString();
    }

    //public void updateLevel()
    //{
    //    levelText.text = GameManger.Instance.CurrentPlayer.Lvl.ToString();
    //}

    //public void updateXP()
    //{
    //    xpText.text = GameManger.Instance.CurrentPlayer.Xp + " / " + GameManger.Instance.CurrentPlayer.RequiredXp;
    //}

    public void menuBtnClicked()
    {
        audioSource.PlayOneShot(menuBtnSound);
//        togleMenu();  
    }

    //public void togleMenu()
    //{
    //    menu.SetActive(!menu.activeSelf);
    //}
}
