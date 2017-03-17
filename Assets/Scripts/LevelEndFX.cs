using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LevelEndFX : MonoBehaviour
{
    private Transform sphere1;
    private Transform sphere2;
    private Transform sphere3;

    // Use this for initialization
    void Start()
    {
        sphere1 = transform.GetChild(0);
        sphere2 = transform.GetChild(1);
        sphere3 = transform.GetChild(2);

        sphere1.DOLocalRotate(new Vector3(0, 0, -180), 1.1f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        sphere2.DOLocalRotate(new Vector3(0, 0, -180), 1.2f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
        sphere3.DOLocalRotate(new Vector3(0, 0, -180), 1.3f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
