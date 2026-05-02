using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material skyboxLobby;
    public Material skyboxDodo;
    public Material skyboxWolf;
    public Material skyboxTurtle;
    public Material skyboxRhino;
    public Material skyboxLeo;

    void Start()
    {
        RenderSettings.skybox = skyboxLobby;
    }

    public void SetSkyboxLobby()
    {
        RenderSettings.skybox = skyboxLobby;
    }

    public void SetSkyboxDodo()
    {
        RenderSettings.skybox = skyboxDodo;
    }

    public void SetSkyboxWolf()
    {
        RenderSettings.skybox = skyboxWolf;
    }

    public void SetSkyboxTurtle()
    {
        RenderSettings.skybox = skyboxTurtle;
    }

    public void SetSkyboxRhino()
    {
        RenderSettings.skybox = skyboxRhino;
    }

    public void SetSkyboxLeo()
    {
        RenderSettings.skybox = skyboxLeo;
    }
}