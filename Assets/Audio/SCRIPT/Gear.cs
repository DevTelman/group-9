using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public float rotationSpeed = 150f;
    public bool isClockwise = true;
    public bool isRotating = false;
    public bool isLocked = false;
    private Vector3 offset;
    private Camera mainCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            float dir = isClockwise? -1f: 1f;
            transform.Rotate(0,0,dir*rotationSpeed*Time.deltaTime);
        }
    }
    void OnMouseDown()
    {
        if(isLocked) return;
        offset = transform.position - GetMouseWorldPos();
    }
    void OnMouseDrag()
    {
       if(isLocked) return;
       transform.position = GetMouseWorldPos()+offset;
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -mainCam.transform.position.z;
        return
        mainCam.ScreenToWorldPoint(mousePos);
    }
}
