using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    
        public void LoadCutscene()
        {
            SceneManager.LoadScene("cutscene");
        }

        public void LoadMarkScene()
    {
        SceneManager.LoadScene("Mark");
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
