using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    private int AmbilScore = 0;

    public float AmbilDataScore()
    {
        return AmbilScore;
    }

    public void TambahScore (int increment)
    {
        AmbilScore += increment;
    }
}
