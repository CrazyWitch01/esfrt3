using UnityEngine;

public class BotonCorrecto : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ObjectToDeactivate; // Asignalo desde el Inspector
    public GameObject CambioAListaUIFruta;

    public AudioSource AudioSource;
    public AudioClip SFX;

    public void Correcto()
    {
        CambioAListaUIFruta.SetActive(true);
        ObjectToDeactivate.SetActive(false);
        AudioSource.PlayOneShot(SFX);
    }
}
