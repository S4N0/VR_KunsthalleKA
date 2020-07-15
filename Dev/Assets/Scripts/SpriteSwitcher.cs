using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwitcher : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Image image;

    private bool firstSprite = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchSprite()
    {
        if (firstSprite)
        {
            image.sprite = sprite2;
        } else
        {
            image.sprite = sprite1;
        }

        firstSprite = !firstSprite;
    }
}
