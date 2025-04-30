using UnityEngine;

public class IfActiveFreezePlazer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        GameObject[] freezeObjects = GameObject.FindGameObjectsWithTag("FreezePlayer");
        bool shouldFreeze = false;

        foreach (GameObject obj in freezeObjects)
        {
            if (obj.activeInHierarchy)
            {
                shouldFreeze = true;
                break;
            }
        }

        if (shouldFreeze)
        {
            rb.linearVelocity = Vector2.zero;
            rb.bodyType = RigidbodyType2D.Static;  // Freezes position completely
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic; // Unfreeze
        }
    }
}
