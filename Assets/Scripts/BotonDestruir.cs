using UnityEngine;

public class BotonDestruir : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject objectToDisable;
    public GameObject UI;

    public AudioSource AudioSource;
    public AudioClip SFX;

    public void DestroyObject()
    {
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);
            UI.SetActive(true);
            AudioSource.PlayOneShot(SFX);

        }
    }
}

