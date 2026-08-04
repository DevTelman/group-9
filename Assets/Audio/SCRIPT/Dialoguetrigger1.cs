using UnityEngine;

public class Dialoguetrigger1 : MonoBehaviour
{
    public DialogueData dataToPlay;
    private static bool hasPlayedInSession = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if( !hasPlayedInSession)
        {
            StartDialogue();
        }
    }
    void StartDialogue()
    {
        hasPlayedInSession = true;
        DialogueManager.Instance.StartDialogue(dataToPlay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
