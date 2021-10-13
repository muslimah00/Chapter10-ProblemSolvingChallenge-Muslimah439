using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager1 : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Text timerText;
    [SerializeField] float duration, currentTime;

    void Start()
    {
        panel.SetActive(false);
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while(currentTime >= 0)
        {
            timerText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        OpenPanel();
    }

    void OpenPanel()
    {
        timerText.text = "";
        panel.SetActive(true);
    }
}
