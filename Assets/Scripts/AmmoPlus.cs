using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPlus : MonoBehaviour
{
    public GameObject playerGun;
    public Gun pg;
    public int ammoGive = 4;

    // Start is called before the first frame update
    void Start()
    {
        playerGun = GameObject.Find("Gun");
        pg = playerGun.gameObject.GetComponent<Gun>();
    }

    public void GiveAmmo()
    {
        if (pg.ammoCount != pg.ammoMax)
            {
                pg.ammoCount += ammoGive;
                if (pg.ammoCount > pg.ammoMax)
                {
                    pg.ammoCount = pg.ammoMax;
                }
                Destroy(gameObject);

        }
    }
}
