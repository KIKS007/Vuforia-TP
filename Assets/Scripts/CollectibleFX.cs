using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollectibleFX : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        transform.DOLocalRotate(new Vector3(0, 0, -180), 1.5f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);

        StartCoroutine(FX());
    }

    IEnumerator FX()
    {
        transform.DOScale(1.3f, 0.5f);

        yield return new WaitForSeconds(0.5f);

        transform.DOScale(1, 0.5f);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(FX());
    }
}
