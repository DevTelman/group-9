using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwapper : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            string currentScene = SceneManager.GetActiveScene().name;
             if (currentScene == "Mark")
            {
            SceneManager.LoadScene("Maluna");
            }
             else if (currentScene == "Maluna")
            {
            SceneManager.LoadScene("Mark");
            }

       
        }
    }    
}