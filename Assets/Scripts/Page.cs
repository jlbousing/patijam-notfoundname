using UnityEngine;
using UnityEngine.SceneManagement;

public class Page : MonoBehaviour
{
    [SerializeField]
    private int sceneIndex = -1;
    public string escena;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName: escena);
            //LoadSceneByIndex();
        }
    }

    //private void LoadSceneByIndex()
    //{
    //    if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
    //    {
    //        SceneManager.LoadScene(sceneName: escena);
    //    }
    //    else
    //    {
    //        Debug.LogError($"El índice de la escena {sceneIndex} no es válido. Verifica Build Settings.");
    //    }
    //}

}
