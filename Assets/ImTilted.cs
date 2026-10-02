using UnityEngine;


public class ImTilted : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 1.0f;

   
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float rotationHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float rotationVertical = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, rotationHorizontal, 0);
        transform.Rotate(rotationVertical, 0, 0);
        
       
    }
}
