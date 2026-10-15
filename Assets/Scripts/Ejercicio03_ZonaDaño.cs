using UnityEngine;

public class Ejercicio03_ZonaDaño : MonoBehaviour
{
    public int damageToIncrease = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ejercicio03_AtributosJugador atributosJugador = other.GetComponent<Ejercicio03_AtributosJugador>();
            atributosJugador.AddDamage(damageToIncrease);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ejercicio03_AtributosJugador atributosJugador = other.GetComponent<Ejercicio03_AtributosJugador>();
            atributosJugador.RestoreDamage();
        }        
    }
}
