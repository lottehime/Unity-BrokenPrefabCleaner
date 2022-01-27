using UnityEngine;
using UnityEditor;

public class CheckBrokenPrefabs : MonoBehaviour
{
    [MenuItem("My Tools/Delete Broken Prefabs")]
    static void CheckPrefabs()
    {
        Debug.Log("We begin...");

        int totalCount = 0;
        int deleteCount = 0;

        string compType = "MeshRenderer";

        string[] objGUIDs = AssetDatabase.FindAssets("t:Object", new[] 
                        { "Assets/PrefabsThatIBroke" });


        foreach (string guid in objGUIDs)
        {
            string objPaths = AssetDatabase.GUIDToAssetPath(guid);
            Object[] objToPrune = AssetDatabase.LoadAllAssetsAtPath(objPaths);

            foreach (Object objActual in objToPrune)
            {
                GameObject obj = AssetDatabase.LoadMainAssetAtPath(
                                            AssetDatabase.GUIDToAssetPath(guid)) as GameObject;

                if (obj && !obj.GetComponent(compType))
                {
                    Debug.LogWarning("Broken prefab found:  " + objActual.name);
                    Debug.Log("Found at: " + objPaths);
                    totalCount++;
                    var tmpName = objActual.name;

                    if (AssetDatabase.DeleteAsset(AssetDatabase.GUIDToAssetPath(guid)))
                    {
                        Debug.LogError("Deleted Asset: " + tmpName);
                        deleteCount++;
                    }
                }
            }
        }

        Debug.Log("We are done. We found: " + totalCount.ToString());
        Debug.Log("We deleted: " + deleteCount.ToString());
    }
}