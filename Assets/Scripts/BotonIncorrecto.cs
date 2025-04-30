using UnityEngine;

public class BotonIncorrecto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public int puzzleIndex; // del 0 al 4
    public ContadorIntentos contador; // Asignalo desde el Inspector
    public AudioSource AudioSource;
    public AudioClip SFX;

    public void RegistrarIntento()
    {
        if (contador != null)
        {
            contador.RegistrarIntento(puzzleIndex);
        }
        AudioSource.PlayOneShot(SFX);
        gameObject.SetActive(false);
    }

}
