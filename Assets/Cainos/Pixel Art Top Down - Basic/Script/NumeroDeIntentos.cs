using UnityEngine;
using TMPro;

public class NumeroDeIntentos : MonoBehaviour
{
    
    public ContadorIntentos contadorIntentos; 
    public int puzzleIndex; 
    public TextMeshProUGUI textoIntentos; 
    private string textoBase; 

    void Start()
    {
        if (textoIntentos != null)
            textoBase = textoIntentos.text; 
    }
    void Update()
    {
        int intentos = contadorIntentos.ObtenerIntentos(puzzleIndex);
        textoIntentos.text = textoBase + " " + intentos.ToString() + " Intentos";
    }
}
