using System.Runtime.CompilerServices;
using UnityEngine;

public class batfollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed ;
    public float stopDistance ;
    private SpriteRenderer sprite;
    public Vector3 offset = new Vector3(0,80f,0);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      sprite =  GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player == null)return;
        Vector3 targetPosition = player.position +offset;
        float distance = Vector3.Distance(transform.position,targetPosition);
        if(distance > stopDistance)
        {
            transform.position = Vector3.Lerp(transform.position,targetPosition,followSpeed *Time.fixedDeltaTime);
        }
        float xDifference = player.position.x - transform.position.x;
        if(xDifference < 0)
        {
            sprite.flipX = true;
        }
        else if (xDifference > 0)
        {
            sprite.flipX = false;
        }
    }
            
        
       
    
}
