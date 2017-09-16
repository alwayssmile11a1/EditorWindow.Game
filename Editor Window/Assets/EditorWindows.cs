using UnityEngine;
using UnityEditor;

public class EditorWindows : EditorWindow {

    string myString = "Hello, World";

    Color color;

    [MenuItem("Window/MyWindow")]
    public static void ShowWindow()
    {
        GetWindow<EditorWindows>("MyWindow");
    }

	void OnGUI()
    {
        //Window code
        GUILayout.Label("This is my Window Editor", EditorStyles.boldLabel);

        myString = EditorGUILayout.TextField("Name", myString);

        color = EditorGUILayout.ColorField("Color", color);

        if(GUILayout.Button("Press me"))
        {
            foreach(GameObject obj in Selection.gameObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if(renderer!=null)
                {
                    renderer.sharedMaterial.color = color;
                }
            }
        }

    }
}
