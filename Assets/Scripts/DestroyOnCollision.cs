using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        

        GetComponent<DestroyOnCollision>().enabled = false;

        yield return new WaitForSeconds(5);

        GetComponent<DestroyOnCollision>().enabled = true;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<DestroyOnCollision>().isActiveAndEnabled)
        {
            if (collision.gameObject.Equals(Enemy))
            {

                Debug.Log("WORKING");
                Destroy(Enemy);
                GameManager.instance.EndGame();
            }
        }
       

       
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
