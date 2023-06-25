using UnityEngine;
using UnityEditor;
 
public class ForceExternalMaterialProcessor : AssetPostprocessor
{
    void OnPreprocessModel()
    {
        var modelImporter = assetImporter as ModelImporter;
        modelImporter.materialLocation = ModelImporterMaterialLocation.External;
    }
}
