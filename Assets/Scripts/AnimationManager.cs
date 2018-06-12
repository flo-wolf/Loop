﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    [Header ("Keyframe Times")]
    public float start;
    public float mid;
    public float end;

    [Header("Keyframe Values")]
    public float startValue;
    public float midValue;
    public float endValue;

    public static AnimationManager instance;

    private void Start()
    {
        instance = this;
    }
}
