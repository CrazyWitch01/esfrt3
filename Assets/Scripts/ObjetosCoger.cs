using UnityEngine;

public class ObjetosCoger : MonoBehaviour
{
    public GameObject objectToActivate; // Objeto a activar cuando el jugador entra en el trigger

    // Esta función se llama cuando otro collider entra en el trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica que el collider que entra sea el jugador
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true); // Activa el objeto
            }

            // Desactiva este GameObject después de activar el otro
            gameObject.SetActive(false);
        }
    }
}
