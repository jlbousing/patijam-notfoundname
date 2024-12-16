using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class EventosMenu
{
    public Action AbrirOpciones { set => _settingsButton.clicked += value; }

    private Button _startButton;
    private Button _settingsButton;
    private Button _exitButton;

    public EventosMenu(VisualElement root)
    {
        _startButton = root.Q<Button>("StartGameButton");
        _settingsButton = root.Q<Button>("SettingsButton");
        _exitButton = root.Q<Button>("ExitButton");

        
        //Salir
        _exitButton.clicked += () => QuitGame();


        //Cambia a escena de juego
        _startButton.clicked += () => SceneManager.LoadScene(sceneName: "Nombre de la escena");

        //AddLogsToButtons();
    }

    //Prueba de botones - mensaje en consola
    //private void AddLogsToButtons()
    //{
    //    _startButton.clicked += () => Debug.Log("Start button clicked");
    //    _settingsButton.clicked += () => Debug.Log("Settings button clicked");
    //    _exitButton.clicked += () => Debug.Log("Quit button clicked");
    //}

    private void QuitGame()
    {
        Application.Quit();
    }
}