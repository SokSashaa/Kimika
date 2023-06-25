using System.Collections.Generic;
using UnityEngine;

public class CreateGamePole : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        DataHolder.Pole = new List<GameObject>();
        for (int i = 0; i < 66; i++)
        {
            DataHolder.Pole.Add(Instantiate(prefab,this.transform));
        }
    }
}