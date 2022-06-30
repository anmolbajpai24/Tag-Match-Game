using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int LevelDuration;
   // public float TimerBeforeStart = 3;
    //public bool TimerBeforeStartHasEnded = false;
    
    


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
        Time.timeScale = 0f;
        Timer();
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().name == "MainMenu")
        //{


       

    }

    // }

    public void Timer()
    {

        if (LevelDuration > 1)
        {
            ///  Debug.Log("Value of levelDuration is " + LevelDuration);
            LevelDuration--;
            Invoke("Timer", 1.0f);

            UiManager.instance.UpdateDuration(LevelDuration);


        }

        else if (LevelDuration == 1)
        {
            Debug.Log("GameOver");
            WinGame();
        }

    }

    public void StartButtonPress()
    {
        Debug.Log("pressed");

        StartCoroutine("StartDelay");

            //if (!TimerBeforeStartHasEnded)
            
        /* {
       
            TimerBeforeStart -= Time.unscaledDeltaTime;
        
           // TimerBeforeStart -= Time.unscaledDeltaTime;

            if (TimerBeforeStart <= 0)
            {
                TimerBeforeStartHasEnded = true;
                
                Debug.Log("Timer" + TimerBeforeStartHasEnded);
                StartGame();
                //UiManager.instance.DisableTimer();
           
        }
        
        }
        */ 

        //yield return new WaitForSecondsRealtime(3);


    }

    IEnumerator StartDelay()
    {
        UiManager.instance.Text3.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text3.SetActive(false);


        UiManager.instance.Text2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text2.SetActive(false);


        UiManager.instance.Text1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        UiManager.instance.Text1.SetActive(false);




        StartGame();

    }

   

    #region LoadingOfScenes
    public void StartGame()
    {
        // Loading the scene 
        // if (TimerBeforeStartHasEnded)
        // {
        UiManager.instance.StartPanel.SetActive(false);
        UiManager.instance.Joystick.SetActive(true);
        Time.timeScale = 1f;
       // }
      
        //SceneManager.LoadScene("DemoSceneRigidbody");

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("VideoRecordingScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void EndGame()
    {
        // Loading Game Over Scene 
        // SceneManager.LoadScene("GameOver");
        UiManager.instance.Joystick.SetActive(false);
        Time.timeScale = 0;
        UiManager.instance.GameOverPanel.SetActive(true);


        


    }

    public void WinGame()
    {
        UiManager.instance.Joystick.SetActive(false);
        Time.timeScale = 0;
        UiManager.instance.GameWinPanel.SetActive(true);
    }
    #endregion

}