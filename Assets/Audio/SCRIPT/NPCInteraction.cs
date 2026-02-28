using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class NPCInteraction : MonoBehaviour
{
    public DialogueData dialogueAsset;
    public float interactionDistance=3f;
    private bool playerInRange;
    public float moveSpeed = 3f;
    public float moveDuration = 3f;
    public Animator animator;
    public AudioSource footstepsAudio;
    private Transform playerTransform;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
   private void OnMouseDown()
    {
      if(DialogueManager.Instance != null)
        {
            DialogueManager.Instance.StartDialogue(dialogueAsset);
        }
    }
  

    
}
