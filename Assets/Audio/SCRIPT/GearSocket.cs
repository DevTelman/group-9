using UnityEngine;

public class GearSocket : MonoBehaviour
{
    public Gear leftGear;
    public Gear rightGear;
    private AudioSource gearSound;
    public static bool isPuzzleSolved = false;
    public GameObject finishButton;
    private void OnTriggerEnter2D(Collider2D other)
    
    
    {
        if (other.CompareTag("MiddleGear"))
        {
            Gear middleGear = other.GetComponent<Gear>();
            if (middleGear != null && !middleGear.isLocked)
            {
                other.transform.position = transform.position;
                middleGear.isLocked = true;
                isPuzzleSolved = true;
                ApplySolvedState();
                middleGear.isRotating = true;
                rightGear.isRotating = true;
                leftGear.isRotating = true;
                middleGear.isClockwise = !leftGear.isClockwise;
                Debug.Log("Gears Connected");
                if (gearSound!= null )
                {
                    gearSound.Play();
                }
                
               
            }
        }
    
    
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gearSound = GetComponent<AudioSource>();
        if (finishButton != null) finishButton.SetActive(false);
        if (isPuzzleSolved)
        {
            ApplySolvedState();
        }
        
            
        
    }
    void ApplySolvedState()
    {
        if(finishButton!= null)finishButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
