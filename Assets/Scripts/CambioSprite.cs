using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CambioSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] buttonSprites;

    [SerializeField] private Image targetButton;

    public void ChangeSprite()
    {
        if (targetButton.sprite == buttonSprites[0])
        {
            targetButton.sprite = buttonSprites[1];
            AudioListener.volume = 0;
            return;
        }

        targetButton.sprite = buttonSprites[0];
        AudioListener.volume = 1;
    }
}