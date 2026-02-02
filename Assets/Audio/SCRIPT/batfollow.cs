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
    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        float distance = Vector3.Distance(transform.position,targetPosition);
        if (distance > 20f)
        {
            transform.position = Vector3.MoveTowards(transform.position,targetPosition,followSpeed *Time.deltaTime);

        }
        float xDifference = player.position.x - transform.position.x;
        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (moveInput > 0)
        {
             GetComponent<SpriteRenderer>().flipX = false;
        }
            
        
       
    }
}
