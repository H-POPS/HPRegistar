

using System.Collections.Generic;
using UnityEngine;

public class FlatRideMod : ModdedObject
{
    public float Excitement;
    public float Intensity;
    public float Nausea;
    public int XSize;
    public int ZSize;
    public Vector3 closedAngleRetraints;
    public List<Waypoint> waypoints = new List<Waypoint>();
    public RideAnimationMod Animation = new RideAnimationMod();

    public override void Decorate()
    {
        //Setup waypoints
        if (Object.GetComponent<Waypoints>())
            Object.GetComponent<Waypoints>().waypoints = waypoints;
        else
            Object.AddComponent<Waypoints>().waypoints = waypoints;

        //Flat Ride sSettings
        CustomFlatRide FR = Object.AddComponent<CustomFlatRide>();
        FR.xSize = XSize;
        FR.zSize = ZSize;
        FR.excitementRating = Excitement;
        FR.intensityRating = Intensity;
        FR.nauseaRating = Nausea;

        //Restraints
        RestraintRotationController controller = Object.AddComponent<RestraintRotationController>();
        controller.closedAngles = closedAngleRetraints;

        //Setup Animation
        FR.motors = Animation.motors;
        FR.phases = Animation.phases;
        foreach (Phase P in FR.phases)
            foreach (RideAnimationEvent RAE in P.Events)
                RAE.Check(FR);

        //Basic FlatRide Settings
        FR.fenceGO = AssetManager.Instance.rideFenceGO;
        FR.entranceGO = AssetManager.Instance.rideEntranceGO;
        FR.exitGO = AssetManager.Instance.rideExitGO;
        FR.entranceExitBuilderGO = AssetManager.Instance.flatRideEntranceExitBuilderGO;
        base.Decorate();
    }
}

