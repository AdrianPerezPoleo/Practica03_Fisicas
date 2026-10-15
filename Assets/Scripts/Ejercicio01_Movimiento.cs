using UnityEngine;

public class Ejercicio01_Movimiento : MonoBehaviour
{

    public float speed = 4.0f;
    private Rigidbody playerRigidbody;
    private Vector3 moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");  // Usamos GetAxisRaw para evitar que, al normalizar, se noten retrasos.
        float vertical = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(horizontal, 0, vertical).normalized;
    }

    void FixedUpdate()
    {
        // Podríamos mejorar el desplazamiento, para hacerlo solo en el eje Z (y que el eje horizontal sea para indicar la rotación).
        // Para ello, tendríamos que utilizar el método MoveRotation de Rigidbody, al que deberíamos pasar un Quaternion.
        // 
        //    float turn = horizontal * turnSpeed * Time.fixedDeltaTime;  // Siendo horizontal y vertical atributos privados.
        //    Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        //    playerRigidbody.MoveRotation(playerRigidbody.rotation * turnRotation);
        //
        //    Vector3 moveZ = transform.forward * vertical * speed * Time.fixedDeltaTime;
        //    playerRigidbody.MovePosition(playerRigidbody.position + moveZ);
        Vector3 nextPosition = playerRigidbody.position + moveDirection * speed * Time.fixedDeltaTime;
        playerRigidbody.MovePosition(nextPosition);
    }
}
