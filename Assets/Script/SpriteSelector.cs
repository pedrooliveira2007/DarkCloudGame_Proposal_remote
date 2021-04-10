using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpriteSelector : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private List<Sprite> sprites;

    private int currentOption = 0;

    public void NesxSprite()
    {
        currentOption++;

        if (currentOption >= sprites.Count)
        {
            currentOption = 0;
        }

        spriteRenderer.sprite = sprites[currentOption];

    }


    public void PrevoiusSprite()
    {
        currentOption--;

        if (currentOption <= 0)
        {
            currentOption = sprites.Count - 1;
        }

        spriteRenderer.sprite = sprites[currentOption];

    }




}
