# Unity Scene View Screenshot Tool

An easy-to-use Unity Editor extension that allows developers to quickly capture screenshots of the active **Scene View** directly within the Unity Editor.

Instead of taking generic full-screen grabs or using runtime scripts, this tool opens a native Unity save dialog so you can name your image and choose its exact destination folder inside your project.

##  Features
- **Header Menu Integration:** Access the tool directly from `Tools > Scene_ScreenShot`.
- **In-Project Save Popup:** Uses `EditorUtility.SaveFilePanelInProject` so you can name the file and pick a folder before saving.
- **Scene View Capture:** Captures the exact pixel resolution of your active Scene View camera.
- **Auto Import:** Instantly refreshes Unity's `AssetDatabase` so the newly created image appears in your Project window right away.

##  How to Use

1. Drop `Scene_ScreenShot.cs` into an `Editor` folder inside your project's `Assets` directory (e.g., `Assets/Scripts/Editor/`).
2. In the top menu bar of Unity, click **Tools > Scene_ScreenShot**.
3. Type your preferred filename in the popup window and click **Save**.
