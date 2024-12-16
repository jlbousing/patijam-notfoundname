using System;
using UnityEngine;
using UnityEngine.UIElements;

public class VistaOpciones
{
    public Action RegresarMenu { set => _backButton.clicked += value; }

    private Button _backButton;
    private Toggle _togglePantallaCompleta;

    public VistaOpciones(VisualElement root)
    {
        _backButton = root.Q<Button>("BotonRegresar");
        _togglePantallaCompleta = root.Q<Toggle>("PantallaCompleta");


        _togglePantallaCompleta.RegisterCallback<MouseUpEvent>((evt) => { PantallaCompleta(_togglePantallaCompleta.value); }, TrickleDown.TrickleDown);

    }

    private void PantallaCompleta(bool enabled)
    {
        Screen.fullScreen = enabled;
    }

}
