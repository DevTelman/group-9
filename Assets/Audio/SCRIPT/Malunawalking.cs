using JetBrains.Annotations;
using UnityEngine;

public class Malunawalking : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       spriteRenderer = GetComponent<SpriteRenderer>();
       anim = GetComponent<Animator>();
      

    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(moveInput*moveSpeed*Time.deltaTime,0,0);
        anim.SetBool("isWalking",moveInput !=0);
    
         rb.MovePosition(transform.position + movement);
        if(moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput > 0)
        {
            spriteRenderer.flipX =false;
        }
    }
}
