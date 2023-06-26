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
    private void Start()
    {
        image = GetComponent<Image>();
        DataHolder.Elements.Add(this);
    }
}