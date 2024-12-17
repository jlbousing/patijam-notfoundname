using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool JuegoEnPausa = false;

    public GameObject menuPausaUI;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoEnPausa)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        menuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        JuegoEnPausa = false;
    }
    public void Pause()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        JuegoEnPausa = true;
    }

    public void SalirdelJuego()
    {
        Application.Quit();
    }

}
