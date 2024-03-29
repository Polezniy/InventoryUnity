using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StatusPlayer
{
    private float hp { get; set; } = 100;
    public float HP
    {
        get { return hp; }
        set { hp = value; }
    }

    private float damage { get; set; } = 10;
    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }
}
