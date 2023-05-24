using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpReset : MonoBehaviour
{
    [SerializeField] private Player player;

    void OnTriggerStay2D(Collider2D c)
    {
        Debug.Log(c.gameObject);
        if (c.gameObject.tag != "Player") {

            Debug.Log("reset");
            player.test();
        }
    }
}
