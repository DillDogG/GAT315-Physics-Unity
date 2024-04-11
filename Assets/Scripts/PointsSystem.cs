using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{
    [SerializeField] TMP_Text pointsUI;
    private float points = 0;
    public float Points
    {
        get { return points; }
        set
        {
            points = value;
            pointsUI.text = "Points: " + points.ToString();
        }
    }

    public void AddPoints(float score)
    {
        Points += score;
    }
}
