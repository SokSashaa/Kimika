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
    public Text description;
    public void OnPointerClick(PointerEventData eventData)
    {
        bool fl = false;
        for (int i = 0; i < DataHolder.Elements.Count; i++)
        {
            int rr = 0;
            Debug.Log(DataHolder.Elements.Count);
            string str = DataHolder.Elements[i].GetComponent<Element>().formula.Replace(" ","");
            if (str != "")
            {
                Debug.Log("111111111111");
                string[] arrFormula = formula.text.Split("+");
                Debug.Log(arrFormula.ToString());
                if (str.Length == formula.text.Length)
                {
                    str = str.Replace("+", "");
                    Debug.Log("str.Length == formula.text.Length");
                    for (int j = 0; j < arrFormula.Length; j++)
                    {
                        if (str.Contains(arrFormula[j]))
                        {
                            Debug.Log("str.Contains(arrFormula[j])");
                            rr++;
                           // str = str.Replace(arrFormula[j],"");
                            if (j == arrFormula.Length - 1)
                            {
                                fl = true;
                                Debug.Log("j == arrFormula.Length - 1");
                            }
                        }
                        else
                        {
                            fl = false; break;
                        }
                    }
                }
                if (rr == arrFormula.Length && fl)
                {
                    imageReact.sprite = DataHolder.Elements[i].GetComponent<Element>().image.sprite;
                    //formulaReact.text = formula.text + "=" + DataHolder.Elements[i].GetComponent<Element>().name1;
                    formulaReact.text = DataHolder.Elements[i].GetComponent<Element>().name2;
                    DataHolder.opened.Add(DataHolder.Elements[i].GetComponent<Element>().name1);
                    description.text = DataHolder.Elements[i].GetComponent<Element>().description;
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
