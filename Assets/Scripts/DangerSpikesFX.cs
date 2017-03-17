using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DangerSpikesFX : MonoBehaviour
{
    private Transform player;
    private bool playerClose = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(FX());
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 5f/100f)
        {
            if (!playerClose)
                StartCoroutine(FX());

            playerClose = true;
        }
        else
            playerClose = false;

    }

    IEnumerator FX()
    {
        transform.DOPunchScale(Vector3.one * 0.2f, 0.15f);

        yield return new WaitForSeconds(0.3f);

        if (playerClose)
            StartCoroutine(FX());
    }
}
