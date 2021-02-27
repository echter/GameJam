using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{

    public PlayerController playerController;

    public Material skyboxMaterial_Level1;
    public Material skyboxMaterial_Level2;
    public Material skyboxMaterial_Level3;
    public Material skyboxMaterial_Level4;

    Material[] skyboxes;


    public GameObject playerGameObject;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxMaterial_Level1;

        skyboxes = new Material[] { skyboxMaterial_Level1, skyboxMaterial_Level2, skyboxMaterial_Level3, skyboxMaterial_Level4 };
    }

    // Update is called once per frame
    void Update()
    {
        float contribution_value = Mathf.Max(0, Mathf.Min(playerController.distanceTraveled * 0.01f, 1.0f)) - 100 * playerController.level;

        RenderSettings.skybox = skyboxes[Mathf.Max(playerController.level - 1, 3)];
        skyboxes[Mathf.Max(playerController.level - 1, 3)].SetFloat("_HorizonLineContribution", contribution_value);
    }
}
