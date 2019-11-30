using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collisioninfo){
        if(collisioninfo.collider.tag == "Finish"){
            FindObjectOfType<GameManager>().WinGame();
        }
    }
}
