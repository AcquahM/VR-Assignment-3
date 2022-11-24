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
        string text = displayText.text;
        int num1 = 0, num2 = 0, op = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != '+' && text[i] != '-')
            {
                if (op == 0) num1 = num1 * 10 + (text[i] - 48);
                else num2 = num2 * 10 + (text[i] - 48);
            }
            else if (text[i] == '+') op = 1;
            else if (text[i] == '-') op = 2;
        }
        displayText.text += buttonText.text + ((op == 1) ? (num1 + num2) : (num1 - num2)).ToString();
    }
}
