using Unity.VisualScripting;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public DialogueData dialogueAsset;
    public float interactionDistance=3f;
    private bool playerInRange;
    private Transform playerTransform;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       GameObject player = GameObject.FindGameObjectWithTag("Player");
       if (player != null)
        {
            playerTransform = player.transform;
        } 
    }

    // Update is called once per frame
   private void OnMouseDown()
   {
      if(playerTransform == null) return;
      float distance = Vector3.Distance(transform.position,playerTransform.position);
      if(distance<= interactionDistance)
        {
            Debug.Log("Close enough to talk");
        }
   }
}
