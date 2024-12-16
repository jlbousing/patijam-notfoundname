using UnityEngine;
using Platformer.Mechanics;

public class Water : MonoBehaviour
{
    private PlayerController playerController;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            playerController = col.gameObject.GetComponent<PlayerController>();
            playerController.maxSpeed = 0.002f;
            playerController.jumpTakeOffSpeed = 2f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            playerController = col.gameObject.GetComponent<PlayerController>();
            playerController.maxSpeed = 3;
            playerController.jumpTakeOffSpeed = 5f;
        }
    }
}
