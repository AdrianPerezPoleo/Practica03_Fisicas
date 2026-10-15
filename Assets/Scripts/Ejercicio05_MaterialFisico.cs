using UnityEngine;

public class Ejercicio05_MaterialFisico : MonoBehaviour
{

    public Vector3 forceVector = new Vector3(0, 0, 2); 
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.Sleep();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            rb.AddForce(forceVector, ForceMode.Impulse);
        }
    }
}
