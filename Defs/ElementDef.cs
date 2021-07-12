using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Element (Def)", menuName = "Scriptable/Element", order = 0)]
public class ElementDef : ScriptableObject
{
    [SerializeField] private string elementName;
    [SerializeField] private Color color;

    //Particules...
    //Colors...
    //Materials...

    public Color getColor() {
        return color;
    }

    public string getName() {
        return elementName;
    }
}
