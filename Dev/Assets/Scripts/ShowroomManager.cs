using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowroomManager : MonoBehaviour
{
    public static ShowroomManager currentShowroomManager;

    public ShowroomLightControl lightControl;
    public EffectControl effectControl;

    int currentColorIndex = 0;

    public GameObject PlayerGameobject;
    public GameObject Projector;

    Color[] colors = new Color[]
    {
        Color.white,
        Color.red,
        Color.green,
        Color.blue,
        Color.cyan,
        Color.yellow
    };

    // Start is called before the first frame update
    void Start()
    {
        currentShowroomManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeInvisible()
    {

    }

    public void ChangeColor()
    {
        //currentColorIndex++;
        //currentColorIndex %= colors.Length;
        //lightControl.Fade(colors[currentColorIndex]);

        effectControl.ChangeColor(colors[currentColorIndex]);
    }

    public void ResetColor()
    {
        currentColorIndex = 0;
        lightControl.Fade(colors[0]);
    }

    public void QuitGame()
    {
        // save any game data here
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
