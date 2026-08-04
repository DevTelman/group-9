using System;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public LevelManager manager;
    public AudioSource clickAudio;
    public int targetRotation = 180;
    public bool islocked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        if(islocked)return;
        if(clickAudio != null)
        {
            clickAudio.Play();
        }
        transform.Rotate(0,0,-90);
        float currentRotation = Mathf.RoundToInt(transform.eulerAngles.z);
        if(currentRotation<0)currentRotation +=360;
        if(Math.Abs(currentRotation-targetRotation)<5f)
        {
            islocked = true;
            if(manager!= null)
            {
                manager.CheckWinCondition();
            }
           
        }
    }
}
