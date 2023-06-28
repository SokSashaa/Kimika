using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class DataHolder
{
    public static List<GameObject> Elements = new List<GameObject>();
    public static int Score = 0;
    public static List<string> opened = new List<string>();
    public static List<GameObject> Slot = new List<GameObject>();
    public static int TargetScore = 999999999;
    public static Image ImageTarget;
    public static string NameTarget;
    public static string NameTarget1;
    public static string DescriptionTarget;
}