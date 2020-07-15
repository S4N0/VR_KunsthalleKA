using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VRTK.Prefabs.Interactions.InteractableSnapZone;
using VRTK.Prefabs.Locomotion.Teleporters;
using Zinnia.Data.Type;

public class PaintingScene : MonoBehaviour
{
    [SerializeField]
    string Name;

    [SerializeField]
    Transform TeleportSpot;

    //[SerializeField]
    //GameObject teleporter;

    Vector3 playerBeforePosition;
    Vector3 projectorBeforePosition;
    Vector3 paintingBeforePosition;

    Transform paintingParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetName()
    {
        return Name;
    }

    public void Teleport(GameObject painting)
    {
        playerBeforePosition = ShowroomManager.currentShowroomManager.PlayerGameobject.transform.position;
        projectorBeforePosition = ShowroomManager.currentShowroomManager.Projector.transform.position;
        paintingBeforePosition = painting.transform.position;
        ShowroomManager.currentShowroomManager.PlayerGameobject.transform.position = new Vector3(
            TeleportSpot.position.x,
            TeleportSpot.position.y, 
            TeleportSpot.position.z);
        ShowroomManager.currentShowroomManager.Projector.transform.position = new Vector3(
            TeleportSpot.position.x - (playerBeforePosition.x - projectorBeforePosition.x),
            TeleportSpot.position.y - (playerBeforePosition.y - projectorBeforePosition.y),
            TeleportSpot.position.z - (playerBeforePosition.z - projectorBeforePosition.z));
        painting.transform.position = new Vector3(
            TeleportSpot.position.x - (playerBeforePosition.x - projectorBeforePosition.x),
            TeleportSpot.position.y - (playerBeforePosition.y - paintingBeforePosition.y),
            TeleportSpot.position.z - (playerBeforePosition.z - projectorBeforePosition.z));

        ShowroomManager.currentShowroomManager.Projector.GetComponentInChildren<SnapZoneFacade>().Unsnapped.AddListener(TeleportBack);

        painting.gameObject.SetActive(true);
    }

    public void TeleportBack(GameObject painting)
    {
        ScenesManager.CurrentScenesManager.BackToShowroom();
        ShowroomManager.currentShowroomManager.Projector.GetComponentInChildren<SnapZoneFacade>().Unsnapped.RemoveListener(TeleportBack);
        ShowroomManager.currentShowroomManager.PlayerGameobject.transform.position = playerBeforePosition;
        ShowroomManager.currentShowroomManager.Projector.transform.position = projectorBeforePosition;
        painting.transform.position = paintingBeforePosition;
    }


}
