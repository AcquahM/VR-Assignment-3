using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearButtonClick : MonoBehaviour
{
    private TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GameObject.Find("Display").GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        displayText.text = "";
    }
}
