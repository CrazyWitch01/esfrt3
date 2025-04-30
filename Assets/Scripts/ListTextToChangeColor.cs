using UnityEngine;
using TMPro;


public class ListTextToChangeColor : MonoBehaviour
{
    public TextMeshProUGUI texto;         // Asigná el texto desde el Inspector
    public string textoExtra = "¡Cambiame!"; // Texto adicional que se agregará
    private bool textoActualizado = false;     // Para evitar que se repita en cada frame

    void Update()
    {
        if (!textoActualizado && texto != null)
        {
            texto.color = Color.red;
            texto.text += " " + textoExtra;
            textoActualizado = true;
        }
    }
}

