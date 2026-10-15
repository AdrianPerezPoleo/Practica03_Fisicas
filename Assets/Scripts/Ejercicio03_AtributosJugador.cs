using UnityEngine;

public class Ejercicio03_AtributosJugador : MonoBehaviour
{
    public int damage = 1;
    public Color playerColor;

    private int originalDamage;
    private Color originalColor;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalDamage = damage;

        if (meshRenderer != null)
        {
            meshRenderer.material.color = playerColor;
            originalColor = playerColor;
        }
    }

    public void AddDamage(int cantidad)
    {
        damage += cantidad;
    }

    public void RestoreDamage()
    {
        damage = originalDamage;
    }

    public void ChangeColor(Color newColor)
    {
        playerColor = newColor;
        if (meshRenderer != null)
        {
            meshRenderer.material.color = playerColor;
        }
    }

    public void RestoreColor()
    {
        playerColor = originalColor;
        if (meshRenderer != null)
        {
            meshRenderer.material.color = playerColor;
        }
    }
}