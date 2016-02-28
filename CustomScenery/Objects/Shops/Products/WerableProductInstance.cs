using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WerableProductInstance : WearableProduct
{

    public WerableProductInstance()
    {

    }

    public override void Initialize()
    {
        this.gameObject.SetActive(true);

        base.Initialize();
    }
}

