using UnityEngine;

public class MIniGameManager : MonoBehaviour
{
    private int maxElement = 0;
    private int minElement = 0;
    void Start()
    {
        maxElement = DataHolder.Elements.Count - 1;
        minElement = DataHolder.Elements.Count - 5;
        if (maxElement < 0)
        {
            maxElement = 0;
            minElement = 0;
        }
        if (minElement < 0)
        {
            minElement = 0;
        }
    }
    void Update()
    {

    }
}
