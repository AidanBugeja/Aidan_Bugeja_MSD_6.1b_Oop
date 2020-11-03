using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Chessbord : MonoBehaviour
{
    public float padding;
    private GameObject[,] grid;


    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[12, 12];
        GameObject myprefab = Resources.Load("Prefabs/Square") as GameObject;
        for (int r=0;r<12; r++)
        {
            for (int c = 0;c <12; c++)
            {
                grid[r, c] = Instantiate(myprefab, new Vector3(c + padding, r + padding), Quaternion.identity);

                if (r % 2 == 0)
                {
                    if (c % 2 == 0)
                    {
                        grid[r, c].GetComponent<SpriteRenderer>().color = Color.black;
                    }
                } 
                else
                {
                    if (c%2 != 0)
                    {

                        grid[r, c].GetComponent<SpriteRenderer>().color = Color.black;
                    }
                }
                }
            }
            
        }

    }


