using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Transform parant;
    private RectTransform rectTransform;
    private Image image;
    public bool Create = true;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Create)
        {
            GameObject GO = Instantiate(this.gameObject, transform.position, transform.rotation, parant);
            image = GO.GetComponent<Image>();
            rectTransform = GO.GetComponent<RectTransform>();
            GO.GetComponent<DragAndDrop>().Create = false;
        }
        else
        {
            image = GetComponent<Image>();
            rectTransform = GetComponent<RectTransform>();
        }
        rectTransform.sizeDelta = new Vector2(200, 200);
        image.color = new Color(0f, 255f, 200f, 0.7f);
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color(255f, 255f, 255f, 1f);
        image.raycastTarget = true;
    }
}
