using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Image image;
    public Sprite tagged;
    public Sprite tag;
    // Start is called before the first frame update
    IEnumerator Start()
    {
      // new WaitForSeconds(10);
        image.sprite = tag;
        yield return new WaitForSeconds(3f);
        image.sprite = tagged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
