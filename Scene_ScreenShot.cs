 using UnityEngine;
 using System.IO;
 using UnityEditor;
 


public class Scene_ScreenShot : MonoBehaviour
{


    
    [MenuItem("Tools/Scene_ScreenShot")]
    static void ScreenShot()
    {

        string PicName = EditorUtility.SaveFilePanelInProject("Save Screenshot", "", "png", "png");
        if (string.IsNullOrEmpty(PicName))
        {
            return;
        }
        SceneView view = SceneView.lastActiveSceneView;
        int width = SceneView.lastActiveSceneView.camera.pixelWidth;
        int height = SceneView.lastActiveSceneView.camera.pixelHeight;
        Texture2D capture = new Texture2D(width, height);
        capture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        capture.Apply();


        byte[] bytes = capture.EncodeToPNG();
        string FileName = PicName;
        File.WriteAllBytes(FileName, bytes);
        DestroyImmediate(capture);

        AssetDatabase.Refresh();

    }

}
