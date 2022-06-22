using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public Text Duration;
    //public Slider slider;
    public Text TimerCountdown;
    public GameObject StartPanel;
    public GameObject GameOverPanel;
    public GameObject GameWinPanel;
    public GameObject Joystick;

    public GameObject Text3;
    public GameObject Text2;
    public GameObject Text1;


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
        
    }

    // Update is called once per frame
    void Update()
    {
       


        

    }

    public void DisableTimer()
    {
        TimerCountdown.enabled = false;
    }

    public void UpdateDuration(int dur)
    {
        
        Duration.text = dur.ToString();
       // slider.value = dur;
        //slider.maxValue = GameManager.instance.LevelDuration;

    }
}
