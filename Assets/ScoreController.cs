using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    public GameObject playerGameObject;

    private void Update()
    {
        score.text = "Distance Score: " + Mathf.Round(playerGameObject.transform.position.z - 20).ToString();
    }
}
