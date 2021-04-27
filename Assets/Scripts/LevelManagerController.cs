using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerController : MonoBehaviour
{
    public float waitToRespawn;
    public PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
 
    void Update()
    {
        
    }

    public void Respawn()
    {
        playerController.gameObject.SetActive(false);
        playerController.transform.position = playerController.respwanPosition;
        playerController.gameObject.SetActive(true);
    }
}
