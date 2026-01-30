using UnityEngine;

public class markwalking : MonoBehaviour
{
    public float moveSpeed ;
    private Rigidbody rb;
    private Animator anim;

    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(moveInput * moveSpeed*Time.deltaTime,0,0);
        rb.MovePosition(transform.position + movement);
       
        anim.SetBool("isWalking",moveInput !=0);
        if (moveInput <0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
