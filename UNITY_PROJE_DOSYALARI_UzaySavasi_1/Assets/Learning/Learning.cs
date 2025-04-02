using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int yokEdilenAsteroid = 5;
        int oyuncuHp = 50;

        Debug.Log(yokEdilenAsteroid <= 5 && oyuncuHp > 50);

        if(yokEdilenAsteroid >= 10 || oyuncuHp >= 80)
        {
            //Debug.Log("Çok güzel");
        }

        //if (yokEdilenAsteroid == 20)
        //{
        //    Debug.Log("Tebrikler oyunu kazandınız!");
        //} else if(yokEdilenAsteroid == 25)
        //{
        //    Debug.Log("Tebrikler birinci oldunuz");
        //} else
        //{
        //    Debug.Log("Maalesef oyunu kaybettiniz :(");
        //}

        //switch(yokEdilenAsteroid)
        //{
        //    case 1:
        //        Debug.Log("Güzel başlangıç");
        //        break;
        //    case 10:
        //        Debug.Log("Bu işte çok iyisin");
        //        break;
        //    default:
        //        Debug.Log("Maalesef oyunu kaybettiniz");
        //        break;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
