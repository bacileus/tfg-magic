using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using PDollarGestureRecognizer;

public class RuneRecognizer : MonoBehaviour
{
    private static RuneRecognizer s_instance;
    private List<Gesture> runeList;
    [SerializeField] private SpellCaster spellCaster;

    void Awake()
    {
        Assert.IsTrue(s_instance == null);
        Debug.Assert(s_instance == null);
        s_instance = this;

        runeList = new List<Gesture>();
        TextAsset[] xmlRunes = Resources.LoadAll<TextAsset>("RuneSet/");
        foreach(TextAsset xmlRune in xmlRunes)
            runeList.Add(GestureIO.ReadGestureFromXML(xmlRune.text));
    }

    public void recognize(List<Point> trailPoints) {
        Point[] arrayPoints = trailPoints.ToArray();
        Gesture currentRune = new Gesture(arrayPoints);
        Result result = PointCloudRecognizer.Classify(currentRune, runeList.ToArray());

        Debug.Log(result.GestureClass + " " + result.Score);
        spellCaster.castSpell(result.GestureClass);
    }

    public static RuneRecognizer instance
    {
        get
        {
            Assert.IsTrue(s_instance != null);
            Debug.Assert(s_instance != null);

            return s_instance;
        }
    }
}
