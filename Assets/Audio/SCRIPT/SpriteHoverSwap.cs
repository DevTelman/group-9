using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteHoverSwap : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite glowingSprite;
    private SpriteRenderer spriteRenderer;
    public string sceneToLoad = "puzzle1";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite= defaultSprite;
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        spriteRenderer.sprite = glowingSprite;
    }
    void OnMouseExit()
    {
        spriteRenderer.sprite = defaultSprite;
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

        
    
}
