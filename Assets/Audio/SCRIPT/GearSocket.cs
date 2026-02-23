using UnityEngine;

public class GearSocket : MonoBehaviour
{
    public Gear leftGear;
    public Gear rightGear;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MiddleGear"))
        {
            Gear middleGear = other.GetComponent<Gear>();
            if (middleGear != null && !middleGear.isLocked)
            {
                other.transform.position = transform.position;
                middleGear.isLocked = true;
                middleGear.isRotating = true;
                rightGear.isRotating = true;
                middleGear.isClockwise = !leftGear.isClockwise;
                Debug.Log("Gears Connected");
            }
        }
    
    
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
