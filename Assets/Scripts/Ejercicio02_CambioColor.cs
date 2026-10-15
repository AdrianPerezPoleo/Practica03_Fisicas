using UnityEngine;

public class Ejercicio02_CambioColor : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    Color CreateNewRandomColor()
    {
        float redPosition = Random.Range(0f, 1f);
        float greenPosition = Random.Range(0f, 1f);
        float bluePosition = Random.Range(0f, 1f);
        return new Color(redPosition, greenPosition, bluePosition);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{gameObject.name} ha colisionado con {collision.gameObject.name}");
        meshRenderer.material.color = CreateNewRandomColor();
    }
}
