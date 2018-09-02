#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateVaisseauCar
{
    [MenuItem("Assets/Create/VaisseauStat")]
    public static VaisseauStat Create()
    {
        VaisseauStat asset = ScriptableObject.CreateInstance<VaisseauStat>();

        AssetDatabase.CreateAsset(asset, "Assets/DONNEES/VAISSEAU/VaisseauStat.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
}
#endif