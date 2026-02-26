using UnityEngine;
[CreateAssetMenu(fileName ="NewDialogue",menuName ="Dialogue/Conversation")]

public class DialogueData : ScriptableObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public DialogueLine[] lines;
}
[System.Serializable]
public class DialogueLine
{
    public string characterName;
    public Sprite characterEmote;
    public string text;
}