using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VillainFollow : MonoBehaviour
{

    public float speed = 3f;
    public Transform player;

    void Awake()
    {
        var playerGameObject = GameObject.FindGameObjectsWithTag("Player")[0];
        var musicController = GameObject.FindGameObjectsWithTag("MusicController")[0];
        var audioSource = musicController.GetComponent<AudioSource>();
        audioSource.volume = 0.2f;
        player = playerGameObject.transform;
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("No se ha asignado un objetivo (bruja) al villano.");
            return;
        }

        Vector3 direction = (player.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("game over");
            RestartCurrentScene();
        }
    }

    private void RestartCurrentScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
