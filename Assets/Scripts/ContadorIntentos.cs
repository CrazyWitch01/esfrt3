using UnityEngine;

public class ContadorIntentos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int[] intentosPorPuzzle = new int[5];
    public void RegistrarIntento(int puzzleIndex)
    {
        if (puzzleIndex >= 0 && puzzleIndex < intentosPorPuzzle.Length)
        {
            intentosPorPuzzle[puzzleIndex]++;
        }
    }

    public int ObtenerIntentos(int puzzleIndex)
    {
        if (puzzleIndex >= 0 && puzzleIndex < intentosPorPuzzle.Length)
            return intentosPorPuzzle[puzzleIndex];
        else
            return -1;
    }
}
