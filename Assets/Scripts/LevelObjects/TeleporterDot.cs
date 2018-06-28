﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterDot : LevelObject
{
    public static TeleporterDot instance;

    ParticleSystem particleFeedback;

    public static bool teleporterTouched;
    public static bool teleportEnabled = true;

	// Use this for initialization
	void Start ()
    {
        instance = this;
        particleFeedback = GetComponent<ParticleSystem>();
        RythmManager.onBPM.AddListener(OnRythmPlayAudio);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        if (collision.gameObject.CompareTag("Player"))
        {
            if(teleportEnabled)
            {
                teleporterTouched = true;
            }
        }
    }

    void OnRythmPlayAudio(BPMinfo bpm)
    {
        if (bpm.Equals(RythmManager.playerBPM) || bpm.Equals(RythmManager.playerDashBPM))
        {
            if ((Player.dot0 != null && Player.dot0.transform.position == transform.position) || (Player.dot1 != null && Player.dot1.transform.position == transform.position))
            {
                AudioManager.instance.Play("Warp");
                particleFeedback.Play();
            }
        }
    }
}
