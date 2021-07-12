using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Assertions;

public class OverrideOrb : MonoBehaviour {

    [SerializeField] private float throwSpeed = 30.0f;
    [SerializeField] private float collisionStallTime = 2.0f;
    [SerializeField] private float stallTime = 5.0f;
    [SerializeField] private AudioClip dropSound;
    [SerializeField] private AudioClip successSound;
    [SerializeField] private AudioClip throwSound;

    private float lastX;
    private float lastY;
    private bool released;
    private bool holding;
    private bool trackingCollisions = false;
    private Rigidbody rigidbody;
    private AudioSource audioSource;
    private InputStatus inputStatus;

    private enum InputStatus {
        Grabbing,
        Holding,
        Releasing,
        None
    }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
        Assert.IsNotNull(audioSource);
        Assert.IsNotNull(rigidbody);
        Assert.IsNotNull(dropSound);
        Assert.IsNotNull(successSound);
        Assert.IsNotNull(throwSound);
    }

    private void Update()
    {
        if (released) {
            return;
        }

        if (holding) {
            FollowInput();
        }

        UpdateInputStatus();


        switch (inputStatus)
        {
            case InputStatus.Grabbing:
                Grab();
                break;
            case InputStatus.Holding:
                Drag();
                break;
            case InputStatus.Releasing:
                Release();
                break;
            case InputStatus.None:
                break;
            default:
                break;
        }
    }

    private void UpdateInputStatus(){
        #if UNITY

        #endif
        #if NOT_UNITY_EDITOR
        #endif
        #if UNITY
    }

    private void FollowInput()
    {

    }

    private void Grab()
    {

    }

    private void Drag()
    {

    }

    private void Release()
    {

    }

    private Vector2 GetInputPosition()
    {

    }

    private void PowerDown()
    {
        Destroy(gameObject);
    }
}
