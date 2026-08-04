using System;
using UnityEngine;

public class PipeRotation : MonoBehaviour
{
      public AudioSource clickAudio;
    public float targetRotation = 0f;
    public bool islocked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void OnMouseDown()
    {
        if (islocked)return;
          if(clickAudio != null)
        {
            clickAudio.Play();
        }
        transform.Rotate(0,0,-90);
        if (Math.Abs(transform.eulerAngles.z - targetRotation) < 1f)
        {
            islocked = true;
        }
    }
}
