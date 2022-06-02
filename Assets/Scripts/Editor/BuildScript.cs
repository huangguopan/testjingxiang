using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript
{
    static void PerformBuild()
    {
        string[] defualtScene = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(defualtScene, "./builds/aa.apk", BuildTarget.Android,BuildOptions.None);
    }
}
