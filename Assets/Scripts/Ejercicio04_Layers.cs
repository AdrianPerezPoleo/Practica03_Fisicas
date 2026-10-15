using UnityEngine;

public class Ejercicio04_Layers : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{gameObject.name}: Se ha disparado el trigger por {other.gameObject.name}");
    }
}
