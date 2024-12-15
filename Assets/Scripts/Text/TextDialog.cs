using UnityEngine;
using TMPro;
using System;

public class TextDialog : MonoBehaviour
{
    public float timeLife = 20;
    public string text = "Hello";
    private TextMeshPro textComponent;

    void Awake()
    {
        textComponent = GetComponent<TextMeshPro>();
        textComponent.text = text;
    }


    void Update()
    {
        timeLife -= Time.deltaTime;

        if(timeLife <= 0) {
           // textComponent.enabled = false;
        }
    }
}
