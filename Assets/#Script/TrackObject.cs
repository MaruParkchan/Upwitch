using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class TrackObject : MonoBehaviour , ITrackableEventHandler
{
    private TrackableBehaviour trackBehaviour;
    private bool isTracked = false;
    public bool IsTracked
    {
        get { return isTracked; }
    }

    private void Awake()
    {
        trackBehaviour = GetComponent<TrackableBehaviour>();
        if (trackBehaviour)
        {
            trackBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {

        if ((newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED))
        {
            isTracked = true;
        }
        else
        {
            isTracked = false;
        }      
    }
}
