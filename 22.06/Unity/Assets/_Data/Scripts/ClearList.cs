using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearList : MonoBehaviour
{
    private void Awake()
    {
        DataHolder.Elements.Clear();
    }
}
