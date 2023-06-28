using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class Slot : MonoBehaviour, IDropHandler
{
    public Text formula; 
    public bool Trigger = false;
    private bool fl;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = 
            GetComponent<RectTransform>().anchoredPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        fl = true;
        for (int i = 0; i < DataHolder.Slot.Count; i++)
        {
            if (DataHolder.Slot[i].GetComponent<Element>().name1 == other.GetComponent<Element>().name1)
            {
                fl = false; break;
            }
        }
        if (fl)
        {
            DataHolder.Slot.Add(other.gameObject);
            if (formula.text == "")
            {
                formula.text = other.GetComponent<Element>().name1;
            }
            else
            {
                formula.text += "+" + other.GetComponent<Element>().name1;
            }
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Trigger = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Trigger = false;
        if (fl)
        {
            formula.text = formula.text.Replace(other.GetComponent<Element>().name1, "");
            formula.text = formula.text.Replace("++", "+");
            if (formula.text.Length != 0)
            {
                if (formula.text.Substring(0, 1) == "+")
                {
                    formula.text = formula.text.Substring(1);
                }
            }
            if (formula.text.Length != 0)
            {
                if (formula.text.Substring(formula.text.Length - 1) == "+")
                {
                    formula.text = formula.text.Substring(0, formula.text.Length - 1);
                }
            }
            DataHolder.Slot.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
        else
        {
            fl = true;
        }
    }
}
