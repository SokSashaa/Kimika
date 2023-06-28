using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Element : MonoBehaviour
{
    [HideInInspector]
    public Image image;
    public string name;
    public string formula;
    public bool open = false;
    public int Score;
    public bool AddDataHolder = true;
    private void Start()
    {
        image = GetComponent<Image>();
        if (AddDataHolder)
        {
            AddDataHolder = false;
            DataHolder.Elements.Add(this.gameObject);
        }
    }
    private void Update()
    {
        if (formula == "")
        {
            if (Score <= DataHolder.Score)
            {
                open = true;
            }
        }
        else
        {
            for (int i = 0; i < DataHolder.opened.Count; i++)
            {
                if (DataHolder.opened[i] == name)
                {
                    open = true;
                }
            }
        }

        if (open)
        {
            transform.SetSiblingIndex(0);
            image.enabled = true;
        }
        else
        {
            image.enabled=false;
        }
    }
}