using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float fMoveSpeed = 7.0f;     // �ړ��l
    public GameObject BulletObj;
    public Vector3 bulletPoint;


    // Start is called before the first frame update
    void Start()
    {
        bulletPoint = transform.Find("BulletPoint").localPosition;;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("F"))
        {
            
            Instantiate(BulletObj, bulletPoint, Quaternion.identity);
        }

    }
}
