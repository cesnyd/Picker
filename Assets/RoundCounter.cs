using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int round;
    static private Text _UI_TEXT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      _UI_TEXT = GetComponent<Text>();
      int remainder = Math.DivRem(Time.time, 30, out quotient); 

        if(remainder == 0)
        {
            round += 1;
            

        }  
        _UI_TEXT.text = Time.time.ToString("#");
    }
}
//"Round:" + round.ToString("#,0"