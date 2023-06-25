using UnityEngine;

public class Ontrigger : MonoBehaviour
{
    public bool isTriger = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTriger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isTriger = false;
    }
}