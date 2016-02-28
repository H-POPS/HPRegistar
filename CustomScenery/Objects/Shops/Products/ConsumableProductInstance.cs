using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConsumableProductInstance : ConsumableProduct
{
    public ConsumableProductInstance()
    {

    }
    public override void Initialize()
    {
        this.gameObject.SetActive(true);

        base.Initialize();
    }
}