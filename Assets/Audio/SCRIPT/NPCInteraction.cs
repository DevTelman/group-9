using Unity.VisualScripting;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public DialogueData dialogueAsset;
    public float interactionDistance=3f;
    private bool playerInRange;
    private Transform playerTransform;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
   public void OnMouseDown()
   {
     if (DialogueManager.Instance != null)
        {
            DialogueManager.Instance.StartDialogue(dialogueAsset);
        }
   }
}
