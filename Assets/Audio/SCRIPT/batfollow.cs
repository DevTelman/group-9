using UnityEngine;

public class batfollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed ;
    public float stopDistance ;
    public Vector3 offset = new Vector3(0,10f,0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = player.position + offset;
        float distance = Vector3.Distance(transform.position,player.position);
        if (distance >stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position,targetPosition,followSpeed *Time.deltaTime);

        }
        if ( player.position.x<transform.position.x)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }
}
