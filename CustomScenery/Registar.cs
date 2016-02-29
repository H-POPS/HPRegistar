using System.Collections.Generic;
using UnityEngine;

public class Registar
{
    private static List<BuildableObject> _customObjects = new List<BuildableObject>();
    private static readonly GameObject _hider = new GameObject();
    
    public static GameObject Register(ModdedObject ModdedObject)
    {
        Debug.Log("=[HPRegistar]======(Registering: " + ModdedObject.Name+ " = Type: "+ ModdedObject.GetType() +")====" );
        try
        {
            GameObject asset = ModdedObject.Object;

            if (asset == null)
            {
                asset = new GameObject();
            }
            ModdedObject.Decorate();
            Object.DontDestroyOnLoad(asset);

            BuildableObject buildableObject = asset.GetComponent<BuildableObject>();
            buildableObject.dontSerialize = true;
            buildableObject.isPreview = true;

            asset.transform.parent = _hider.transform;

            AssetManager.Instance.registerObject(buildableObject);
            Debug.Log("=[HPRegistar]======(Succelfully Registering: " + ModdedObject.Name + ")====");
            return asset;
        }

        catch (System.Exception e)
        {

            Debug.Log("=[HPRegistar]======(Error)==[" + e + "]==");
            return null;
        }
    }
}

