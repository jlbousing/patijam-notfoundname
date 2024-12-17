using UnityEngine;
using UnityEngine.UI;

public class ContadorPaginas : MonoBehaviour
{
    public int pageCount;
    public Text textoPaginas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoPaginas.text = ": " + pageCount.ToString();
    }
}
