using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private AbrirPorta door;

    private void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            door.OpenDoor();
        }
        if(Input.GetKeyDown(KeyCode.L)){
            door.CloseDoor();
        }
    }
}
