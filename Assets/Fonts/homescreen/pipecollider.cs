using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class pipecollider : MonoBehaviour
{
     public Sprite defaultsprite;
    
    public Sprite glowingsprite;
    private SpriteRenderer spriteRenderer;
    public string sceneToLoad = "pipe";
    public TextMeshProUGUI notificationText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite= defaultsprite;
        if (notificationText != null)
        {
            notificationText.text ="";
        }
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        spriteRenderer.sprite = glowingsprite;
    }
    void OnMouseExit()
    {
        spriteRenderer.sprite = defaultsprite;
    }
    void OnMouseDown()
    {
        

        if(GearSocket.isPuzzleSolved == true)
        {
      
      
        
         SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(ShowAlertSequence());
        }

    }
    IEnumerator ShowAlertSequence()
    {
        if (notificationText != null)
        {
            notificationText.text ="Go back to Mark level and solve gear puzzle";
            yield return new WaitForSeconds(10f);
            notificationText.text ="";
        }
    }

        
}
