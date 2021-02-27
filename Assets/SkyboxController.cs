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
    public Material skyboxMaterial_Level5;
    public Material skyboxMaterial_Level6;

    public Material ground_Level1;
    public Material ground_Level2;
    public Material ground_Level3;
    public Material ground_Level4;
    public Material ground_Level5;
    public Material ground_Level6;

    public Material currentSkyboxMaterial;

    public GameObject groundGameObject;

    Material[] skyboxes;
    Material[] grounds;

    int previousLevel = 1;


    public GameObject playerGameObject;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxMaterial_Level1;

        skyboxes = new Material[] { skyboxMaterial_Level1, skyboxMaterial_Level2, skyboxMaterial_Level3, skyboxMaterial_Level4, skyboxMaterial_Level5, skyboxMaterial_Level6 };
        grounds = new Material[] { ground_Level1, ground_Level2, ground_Level3, ground_Level4, ground_Level5, ground_Level6 };
    }

    // Update is called once per frame
    void Update()
    {
        float contribution_value = Mathf.Max(0, Mathf.Min((playerController.distanceTraveled - 100 * playerController.level) * 0.01f, 1.0f));
        if (playerController.level != previousLevel)
        {
            RenderSettings.skybox = skyboxes[Mathf.Min(playerController.level - 1, skyboxes.Length - 1)];
            groundGameObject.GetComponent<Renderer>().material = grounds[Mathf.Min(playerController.level - 1, skyboxes.Length - 1)];
            previousLevel = playerController.level;
        }
        currentSkyboxMaterial = skyboxes[Mathf.Min(playerController.level - 1, skyboxes.Length - 1)];
        currentSkyboxMaterial.SetFloat("_HorizonLineContribution", contribution_value);
    }
}
