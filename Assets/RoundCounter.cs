using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;
    static private Text _UI_TEXT;
    private float roundTimes = 30f;

    void Awake()
    {
        _UI_TEXT = GetComponent<Text>();

    }
    void Update()
    {
        if (Time.time >= roundTimes)
        {
            round += 1;
            roundTimes += 30f;

        }
        _UI_TEXT.text = "Round: " + round.ToString("#");
    }
}
