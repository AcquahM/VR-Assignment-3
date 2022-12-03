using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EqualButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI displayText;
    private TextMeshProUGUI buttonText;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GameObject.Find("Display").GetComponentInChildren<TextMeshProUGUI>();
        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void Click()
    {
        var text = displayText.text;
        int acc = 0, delta = 0, sign = 1;
        for(var i = 0; i < text.Length; i++)
        {
            if (text[i] != '+' && text[i] != '-')
            {
                delta = delta * 10 + (text[i] - 48);
            }
            else
            {
                acc += sign * delta;
                delta = 0;
                sign = text[i] == '+' ? 1 : -1;
            }
        }
        acc += sign * delta;
        displayText.text = $"{text}={acc.ToString()}";
    }
}
