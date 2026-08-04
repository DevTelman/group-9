using UnityEngine;
using TMPro; 
using UnityEngine.UI;
using System.Collections;
using NUnit.Framework;

public class wardenhover : MonoBehaviour

   
{
   
   public TextMeshProUGUI dialogueText;
            private Coroutine textCoroutine;
    private Animator animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        if(dialogueText != null)dialogueText.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        animator.SetBool("isHovered",true);
    }
    void OnMouseExit()
    {
       animator.SetBool("isHovered",false);
    }
    void OnMouseDown()
    {
       if(dialogueText != null)
        {
            if(textCoroutine != null)StopCoroutine(textCoroutine);
            textCoroutine = StartCoroutine(ShowTextRoutine());
        }

    }
    IEnumerator ShowTextRoutine()
    {
        dialogueText.text = "Click on character icon to continue the dialogue";
        dialogueText.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);
        dialogueText.gameObject.SetActive(false);
    }

        
}
