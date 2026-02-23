using UnityEngine;
using TMPro;
using System.Collections;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textElement;
    public string  fullText;
    public float delay = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        textElement.text = "";
        foreach (char c in fullText)
        {
            textElement.text +=c;
            yield return new WaitForSeconds(delay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
