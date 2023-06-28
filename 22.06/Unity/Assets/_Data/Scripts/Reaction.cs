using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using Unity.VisualScripting;

public class Reaction : MonoBehaviour, IPointerClickHandler
{
    public GameObject Error;
    public GameObject React;
    public Image imageReact;
    public Text formulaReact;
    public Text formula;
    public void OnPointerClick(PointerEventData eventData)
    {
        bool fl = false;
        for (int i = 0; i < DataHolder.Elements.Count; i++)
        {
            Debug.Log(DataHolder.Elements.Count);
            string str = DataHolder.Elements[i].GetComponent<Element>().formula;
            if (str != "")
            {
                string[] arrFormula = formula.text.Split("+");
                if (str.Length == formula.text.Length)
                {
                    str = str.Replace("+", "");
                    for (int j = 0; j < arrFormula.Length; j++)
                    {
                        if (str.Contains(arrFormula[j]))
                        {
                            str = str.Replace(arrFormula[j],"");
                            if (j == arrFormula.Length - 1)
                            {
                                fl = true;
                            }
                        }
                        else
                        {
                            fl = false; break;
                        }
                    }
                }
                if (str == "" && fl)
                {
                    imageReact.sprite = DataHolder.Elements[i].GetComponent<Element>().image.sprite;
                    formulaReact.text = formula.text + "=" + DataHolder.Elements[i].GetComponent<Element>().name;
                    DataHolder.opened.Add(DataHolder.Elements[i].GetComponent<Element>().name);
                    React.SetActive(true); break;
                }
            }
        }
        if (!fl)
        {
            Error.SetActive(true);
        }
    }
}