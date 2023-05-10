using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class PlayFootstepSound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool IsMoving;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") + Input.GetAxis("Horizontal") != 0)
        {
            IsMoving = true;
        }
        else IsMoving = false;

        if (IsMoving && !audioSource.isPlaying) audioSource.Play(); // Checks if the player is moving and if the audio source is not playing, then plays the audio.
        if (!IsMoving) audioSource.Stop(); // Checks if the player is not moving, then stops audio if they aren't.
    }
}
