using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Text))]
public class Element : MonoBehaviour
{
    [HideInInspector]
    public Image image;
    [HideInInspector]
    public Text formula;
    public bool open = false;
    private void Start()
    {
        image = GetComponent<Image>();
        formula = GetComponent<Text>();
        DataHolder.Elements.Add(this);
    }
}