using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTarget : MonoBehaviour
{
    public void Target()
    {
        DataHolder.TargetScore = 999999999;
        for (int i = 0; i < DataHolder.Elements.Count; i++)
        {
            Element el = DataHolder.Elements[i].GetComponent<Element>();
            if (el.Score != 0)
            {
                if (!el.open)
                {
                    if (el.Score < DataHolder.TargetScore)
                    {
                        DataHolder.TargetScore = el.Score;
                        DataHolder.NameTarget = el.name2;
                        DataHolder.ImageTarget = el.image;
                        DataHolder.DescriptionTarget = el.description;
                    }
                }
            }
        }
    }
}
