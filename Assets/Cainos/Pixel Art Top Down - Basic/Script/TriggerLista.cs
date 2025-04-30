using UnityEngine;

public class TriggerLista : MonoBehaviour
{
    public GameObject[] objectsToCheck; // Assign your 4 objects here
    public GameObject objectToActivate; // The object to activate

    void Update()
    {
        if (AllObjectsDisabled())
        {
            objectToActivate.SetActive(true);
            enabled = false; // Optional: stop checking once activated
        }
    }

    bool AllObjectsDisabled()
    {
        foreach (GameObject obj in objectsToCheck)
        {
            if (obj != null && obj.activeInHierarchy)
                return false;
        }
        return true;
    }
}
