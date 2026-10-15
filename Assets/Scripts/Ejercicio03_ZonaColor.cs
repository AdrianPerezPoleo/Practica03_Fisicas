using UnityEngine;

public class Ejercicio03_ZonaColor : MonoBehaviour
{
    public Color colorToAssign = new Color(0, 0, 0);

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ejercicio03_AtributosJugador atributosJugador = other.GetComponent<Ejercicio03_AtributosJugador>();
            atributosJugador.ChangeColor(colorToAssign);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ejercicio03_AtributosJugador atributosJugador = other.GetComponent<Ejercicio03_AtributosJugador>();
            atributosJugador.RestoreColor();
        }        
    }
}
