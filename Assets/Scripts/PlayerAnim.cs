using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{

    private Player player;
    private Animator anim;

    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(player.direction.sqrMagnitude > 0)
        {
            anim.SetInteger("transition", 1);
        } else
        {
            anim.SetInteger("transition", 0);
        }

        if(player.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (player.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}
