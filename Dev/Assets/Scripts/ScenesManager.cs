using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Type;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager CurrentScenesManager;

    public GameObject Showroom;
    public PaintingScene[] Scenes;

    TransformData lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScenesManager = this;
        BackToShowroom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportTo(GameObject paintingObject)
    {
        IPaintingManager painting = paintingObject.GetComponent<IPaintingManager>();
        //Debug.Log("Teleport to " + sceneName);
        string sceneName = painting.GetSceneName();
        foreach (PaintingScene cScene in Scenes)
        {
            Debug.Log(cScene.GetName() + " == " + sceneName + "?");
            if (cScene.GetName() == sceneName)
            {
                ActivateScene(cScene);
                cScene.Teleport(paintingObject);
            }
        }
    }

    private void ActivateScene(PaintingScene scene)
    {
        PaintingVisibilityManager.currentPaintingVisibilityManager.DeactivateAll();
        scene.gameObject.SetActive(true);
        Showroom.SetActive(false);
    }

    public void BackToShowroom()
    {
        foreach (PaintingScene scene in Scenes)
        {
            scene.gameObject.SetActive(false);
        }

        Showroom.SetActive(true);

        PaintingVisibilityManager.currentPaintingVisibilityManager?.ActivateAll();
    }

    //public void TeleportTo(int sceneIndex)
    //{
    //    Scenes[sceneIndex].Teleport();
    //}

    public void PaintingSnapped(GameObject paintingObject)
    {
        Debug.Log("Snapped");
        //IPaintingManager painting = paintingObject.GetComponent<IPaintingManager>();
        //lastPosition = new TransformData()
        TeleportTo(paintingObject);
    }

    public void PaintingUnsnapped(GameObject paintingObject)
    {
        //GetComponent<ScenesManager>().TeleportTo(painting.GetSceneName());
    }
}
