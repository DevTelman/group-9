using UnityEngine;
using UnityEngine.SceneManagement;

public class exitportal : MonoBehaviour
{
    public string sceneToLoad = "Maluna";
    public AudioSource clickSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        if(clickSound!= null)
        {
            clickSound.Play();
        }
        SceneManager.LoadScene(sceneToLoad);
    }
}
