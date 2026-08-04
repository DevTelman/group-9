using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject exitObject;
    public Pipe[]allPipes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if(exitObject != null)exitObject.SetActive(false);
       
    }
    public void CheckWinCondition()
    {
        foreach(Pipe p in allPipes)
        {
            if(!p.islocked)return;
        }
        if(exitObject != null)
        {
            exitObject.SetActive(true);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
