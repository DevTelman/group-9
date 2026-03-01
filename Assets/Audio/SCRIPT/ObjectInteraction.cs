using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteraction : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite glowingSprite;
    public string sceneToLoad = "cutscene2";
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnMouseEnter()
    {
        spriteRenderer.sprite = glowingSprite;
    }
    void OnMouseExit()
    {
        spriteRenderer.sprite= normalSprite;
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
