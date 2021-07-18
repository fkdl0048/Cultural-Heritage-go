using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class CaptureSceneUIManger : MonoBehaviour {

    [SerializeField] private CaptureSceneManger manager;
    [SerializeField] private GameObject successScreen;
    [SerializeField] private GameObject failScreen;
    [SerializeField] private GameObject gameScreen;

    private void Awake()
    {
        Assert.IsNotNull(manager);
        Assert.IsNotNull(successScreen);
        Assert.IsNotNull(failScreen);
        Assert.IsNotNull(gameScreen);
    }
    
    void Update () {
        switch (manager.Status) {
            case CaptureSceneStatus.InProgress:
                HandleInProgress();
                break;
            case CaptureSceneStatus.Successful:
                HandleSuccess();
                break;
            case CaptureSceneStatus.Failed:
                HandleFailure();
                break;
            default:
                break;
        }
	}

    private void HandleInProgress()
    {
        UpdateVisibleScreen();
    }

    private void HandleSuccess()
    {
        UpdateVisibleScreen();
    }

    private void HandleFailure()
    {
        UpdateVisibleScreen();
    }

    private void UpdateVisibleScreen()
    {
        successScreen.SetActive(manager.Status == CaptureSceneStatus.Successful);
        failScreen.SetActive(manager.Status == CaptureSceneStatus.Failed);
        gameScreen.SetActive(manager.Status == CaptureSceneStatus.InProgress);
    }
}
