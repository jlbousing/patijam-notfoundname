using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogArea : MonoBehaviour
{

    public GameObject textDialog;
    private bool isTextGenerated = false;


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("entrando en trigger");

        if (!isTextGenerated && col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            var textPosition = new Vector3(
                col.gameObject.transform.position.x,
                col.gameObject.transform.position.y,
                -3f
            );
            var text = Instantiate(textDialog, textPosition, col.gameObject.transform.rotation);
            isTextGenerated = true;
        }
    }
}
