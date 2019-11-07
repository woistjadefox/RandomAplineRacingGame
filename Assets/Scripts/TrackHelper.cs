using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGSpline.Curve;
using BansheeGz.BGSpline.Components;

public class TrackHelper : MonoBehaviour
{

    [SerializeField]
    private float minDistanceToShowHelper = 10;

    [SerializeField]
    private Transform vehicle;

    [SerializeField]
    private BGCcMath curve;

    [SerializeField]
    private Transform trackHelper;

    private void Start() {
        
    }

    private void Update()
    {
        Vector3 pos = curve.CalcPositionByClosestPoint(vehicle.position);
        trackHelper.position = pos;

        float distance = Vector3.Distance(vehicle.position, pos);

        if(distance > minDistanceToShowHelper) {
            trackHelper.gameObject.SetActive(true);
        } else {
            trackHelper.gameObject.SetActive(false);
        }
    }
}
