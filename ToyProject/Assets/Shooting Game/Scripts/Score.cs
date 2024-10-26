using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    [Header("¼Ó¼º")]
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI bestscore;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = $"Score : {score}";
    }
}
