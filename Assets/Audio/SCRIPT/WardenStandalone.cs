using UnityEngine;

public class WardenStandalone : MonoBehaviour
{
    public Animator wardenAnimator;
    public AudioSource footstepsAudio;
    public float walkSpeed = 3f;
    private bool isWalking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void Update()
    {
        if (isWalking)
        {
            transform.Translate(Vector3.left *walkSpeed*Time.deltaTime);
        }
    }
    public void PlayFootstep()
    {
        if (footstepsAudio != null)
        {
            footstepsAudio.Play();
        }
    }
    public void DestroyWarden()
    {
        Destroy(gameObject);
    }
    public void StartWardenSequence()
    {
        if (wardenAnimator != null)
        {
            wardenAnimator.SetBool("isWalking" ,true);
        }
    }
}

