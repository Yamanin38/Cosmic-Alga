using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroll : MonoBehaviour
{
    // 背景をスクロールする速度
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 背景スクロールする処理
        transform.position -= new Vector3(0, Time.deltaTime * speed);
 
        if(transform.position.y <= -21.5f)
        {
            transform.position = new Vector3(0, 21.5f);
        }
    }
}
