using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.Equals(Enemy))
        {
           Destroy(Enemy);
            GameManager.instance.EndGame();
       }

        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("YSESEYSEYES");
            GameManager.instance.EndGame();
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
