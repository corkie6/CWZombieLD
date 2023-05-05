using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedsPlus : MonoBehaviour
{
    public GameObject player;
    public PlayerDamage pee;
    public int healthGive = 20;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ThirdPersonPlayer_WithCamera");
        pee = player.gameObject.GetComponent<PlayerDamage>();
    }

    // Update is called once per frame
    public void HealPlayer()
    {
        pee.health += healthGive;
        Destroy(gameObject);
    }
}
