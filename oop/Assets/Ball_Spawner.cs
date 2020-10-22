using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Ball_Spawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mypos = new Vector3(7.5f, 7.5f, 0);
        Vector3 mypos2 = new Vector3(-7.5f, -7.5f, 0);
        Vector3 mypos3 = new Vector3(-7.5f, 7.5f, 0);
        Vector3 mypos4 = new Vector3(7.5f, -7.5f, 0);
       GameObject mycircle1 = Instantiate(myCirclePrefab, mypos , Quaternion.identity);
       GameObject mycircle2 = Instantiate(myCirclePrefab, mypos2, Quaternion.identity);
       GameObject mycircle3 = Instantiate(myCirclePrefab, mypos3, Quaternion.identity);
       GameObject mycircle4 = Instantiate(myCirclePrefab, mypos4, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
