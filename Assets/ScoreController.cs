using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI level;

    public GameObject playerGameObject;
    public PlayerController playerController;

    private void Update()
    {
        score.text = "Distance Score: " + Mathf.Round(playerGameObject.transform.position.z - 20).ToString();
        level.text = "Level: " + playerController.level.ToString();
    }
}
