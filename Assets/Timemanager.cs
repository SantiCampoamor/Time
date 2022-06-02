using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager : MonoBehaviour
{
    public Text txt_time;
    public Text txt_time2;
    public Text txt_time_min;
    public Text txt_time_seg;
    public GameObject txtPerdiste;
    public bool isCounting;
    public float elapsedTime;

    void Start()
    {
        elapsedTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        txt_time.text = currentTime.ToString();

        txt_time2.text = Mathf.Floor(currentTime).ToString();

        int minutos = Mathf.FloorToInt(((currentTime + 100) / 60));
        txt_time_min.text = minutos.ToString();

        txt_time_seg.text = (currentTime % 60).ToString();
        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }
        if (currentTime > 10)
        {
            txtPerdiste.SetActive(true);
        }
    }
}
