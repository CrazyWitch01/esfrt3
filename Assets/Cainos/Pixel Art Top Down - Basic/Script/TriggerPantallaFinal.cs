using UnityEngine;

public class TriggerPantallaFinal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Asignalo desde el Inspector
    public GameObject PantallaFinal;


    public void PantallaFinalActivar()
    {
        PantallaFinal.SetActive(true);
       
    }
}
