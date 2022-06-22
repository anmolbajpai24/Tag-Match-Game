using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    public static TimeSlider instance;

    public Slider timerSlider;
    public float gameTime;
    

    private bool stopGame;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       
        stopGame = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60);


        if (time <= 0)
        {
            stopGame = true;
        }

        if(stopGame == false)
        {
            timerSlider.value = time;
        }
    }
}
