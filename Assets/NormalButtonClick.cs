using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class NormalButtonClick : MonoBehaviour
{
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
        displayText.text += buttonText.text;
    }
}
