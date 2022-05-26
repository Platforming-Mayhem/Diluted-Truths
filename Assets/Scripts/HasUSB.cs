using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasUSB : MonoBehaviour
{
    public BoxCollider trig;
    PlayerScript player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!player.hasUSB1)
        {
            trig.enabled = false;
        }
        else
        {
            trig.enabled = true;
        }
    }
}
