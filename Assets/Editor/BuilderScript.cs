using UnityEditor;
class WebGLBuilder
{
    static void build()
    {

        // Place all your scenes here
        string[] scenes = {"Assets/Scenes/Demo.unity"};

        //string pathToDeploy = "D:/PROJECTS/BuildTest/WINDOWS_BUILD";

        BuildPlayerOptions ops = new BuildPlayerOptions();
        ops.scenes = scenes;
        ops.target = BuildTarget.WebGL;
        ops.locationPathName = "D:/PROJECTS/BuildTest/WEBGL_BUILD/v1";

        BuildPipeline.BuildPlayer(ops);
    }
}