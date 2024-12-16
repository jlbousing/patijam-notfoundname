using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VistaIniciall : MonoBehaviour
{
    private VisualElement _settingsView;
    private VisualElement _startView;
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        _startView = root.Q("ArbolVisualMenuPrincipal");
        _settingsView = root.Q("MenuOpciones");

        SetupMenuPrincipal();
        SetupMenuOpciones();
    }
     
    
    private void SetupMenuPrincipal()
    { 
        EventosMenu menuPresenter = new EventosMenu(_startView);
        menuPresenter.AbrirOpciones = () => ToggleMenuOpciones(true);
    }

    private void SetupMenuOpciones()
    { 
        VistaOpciones settingsPresenter = new VistaOpciones(_settingsView);
        settingsPresenter.RegresarMenu = () => ToggleMenuOpciones(false);
    }

     private void ToggleMenuOpciones(bool enable)
     {
        _startView.Display(!enable);
        _settingsView.Display(enable);
     }

}
