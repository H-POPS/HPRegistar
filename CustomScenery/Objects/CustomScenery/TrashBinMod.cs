
public class TrashBinMod : ModdedObject
{

    public override void Decorate()
    {
        Object.AddComponent<TrashBin>();
        base.Decorate();
    }
}

