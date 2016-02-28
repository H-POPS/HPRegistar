
using System;
using UnityEngine;
using System.Linq;

[ExecuteInEditMode]
[Serializable]
public class ApplyRotation : RideAnimationEvent 
{
    
    public MultipleRotationsHP rotator;
    
    float lastTime;

    public override void Check(CustomFlatRide RA)
    {
        foreach (MultipleRotationsHP R in RA.motors.OfType<MultipleRotationsHP>().ToList())
            if (R.Identifier == identifierMotor)
            {
                rotator = R;
            }
        base.Check(RA);
    }
    public override string EventName
    {
        get
        {
            return "ApplyRptations";
        }
    }
    
    

    public override void Enter()
    {
        
    }
    public override void Run()
    {
        if (rotator)
        {
            rotator.tick(Time.deltaTime);
            lastTime = Time.realtimeSinceStartup;
            done = true;
            base.Run();
        }

    }
}
