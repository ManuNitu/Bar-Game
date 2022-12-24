using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using TMPro;
//[CustomEditor(typeof(Level))]
public class LevelEditor : MonoBehaviour //Editor
{
    public static List<GameObject> spawnedPieces = new List<GameObject>();

    //public override void OnInspectorGUI()
    //{
    //    Level levelScript = (Level)target;

    //    levelScript.levelText = (TextMeshProUGUI)EditorGUILayout.ObjectField("LevelText", levelScript.levelText, typeof(TextMeshProUGUI), true);

    //    serializedObject.Update();

    //    EditorGUILayout.PropertyField(serializedObject.FindProperty("lenght"), true);

    //    EditorGUILayout.PropertyField(serializedObject.FindProperty("EndPiece"), true);

    //    EditorGUILayout.PropertyField(serializedObject.FindProperty("MidPieces"), true);

    //    serializedObject.ApplyModifiedProperties();

    //    if(GUILayout.Button("Generate Level"))
    //    {
    //        for(int i = 0; i < spawnedPieces.Count; i++)
    //        {
    //            DestroyImmediate(spawnedPieces[i].gameObject);
    //        }
    //        spawnedPieces.Clear();
    //        levelScript.EndPiece.transform.position = new Vector3(0f, 0f, (7.5f * levelScript.lenght) - 2.5f);
    //        for (int i = 0; i < levelScript.lenght; i++)
    //        {
    //            int rand = Random.Range(0, levelScript.MidPieces.Length);
    //            GameObject newPiece = Instantiate(levelScript.MidPieces[rand], new Vector3(0f, 0f, (7.5f*i)-2.5f), Quaternion.identity);
    //            spawnedPieces.Add(newPiece);
    //        }
    //    }
    //}
}
