﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy")]

public class Enemy : ScriptableObject {
    public float Health;
    public float Damage;
    public bool Alive;
    public GameObject Target;
	
}
