using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void HitEnemy(string hittag)
    {
        if(hittag=="Enemy")
        {
            score += 100;
        }
    }
}
