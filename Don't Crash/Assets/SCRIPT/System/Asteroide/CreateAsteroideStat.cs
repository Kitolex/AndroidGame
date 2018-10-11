#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateAsteroideStat  {

    [MenuItem("Assets/Create/Donnees Jeu/AsteroideStat")]
    public static AsteroideStat Create()
    {
        AsteroideStat asset = ScriptableObject.CreateInstance<AsteroideStat>();

        AssetDatabase.CreateAsset(asset, "Assets/DONNEES/ASTEROIDES/AsteroideStat.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
}
#endif