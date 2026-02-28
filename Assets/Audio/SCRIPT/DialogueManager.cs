using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;
    public GameObject dialoguePanel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image portraitImage;
    public float typingSpeed = 0.04f;
    private int index;
    private DialogueData currentDialogue;
    private bool isTyping;
    public WardenStandalone warden;
   
    void Awake()
    {
        Instance = this;
        if(dialoguePanel != null)dialoguePanel.SetActive(false);
    }
    public void StartDialogue(DialogueData data)
    {
        currentDialogue = data;
        index = 0;
        dialoguePanel.SetActive(true);
        StartCoroutine(TypeLine());

    }
    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogueText.text = "";
        nameText.text = currentDialogue.lines[index].characterName;
        portraitImage.sprite = currentDialogue.lines[index].characterEmote;
        foreach (char c in currentDialogue.lines[index].text.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;

       
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& dialoguePanel.activeSelf)
        {
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = currentDialogue.lines[index].text;
                isTyping = false;
            }
            else {NextLine();}
        }
    }
    void NextLine()
    {
        if (index < currentDialogue.lines.Length - 1)
        {
            index ++;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialoguePanel.SetActive(false);
            if(warden != null)
            {
                warden.StartWardenSequence();
            }
        }
       
    }
}

