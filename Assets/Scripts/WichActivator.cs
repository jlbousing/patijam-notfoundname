using UnityEngine;

public class WichActivator : MonoBehaviour
{
    public GameObject which;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Aparece la bruja");
            var whichPosition = new Vector3(
                transform.position.x,
                transform.position.y + 15f,

                0f
            );

            Instantiate(which, whichPosition, col.gameObject.transform.rotation);
            Destroy(this);
        }
    }
}
