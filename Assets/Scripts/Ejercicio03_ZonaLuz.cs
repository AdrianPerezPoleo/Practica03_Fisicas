using Unity.VectorGraphics;
using UnityEngine;

public class Ejercicio03_ZonaLuz : MonoBehaviour
{

    public Color newColor = new Color(0, 0, 1);
    public float newIntensity = 3f;

    private float originalIntensity;
    private Color originalColor;

    private Light sceneLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject lightObject = GameObject.FindWithTag("Light");
        if (lightObject != null)
        {
            sceneLight = lightObject.GetComponent<Light>();
            if (sceneLight != null)
            {
                originalIntensity = sceneLight.intensity;
                originalColor = sceneLight.color;                  
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && sceneLight != null)
        {
            sceneLight.intensity = newIntensity;
            sceneLight.color = newColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && sceneLight != null)
        {
            sceneLight.intensity = originalIntensity;
            sceneLight.color = originalColor;
        }
    }
}
