using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimations : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while(true)
        {
            yield return new WaitForSeconds(1);

            anim.SetInteger(("JumpIndex"),Random.Range(0, 6));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
