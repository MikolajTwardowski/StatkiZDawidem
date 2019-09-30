using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    //public List<GameObject> siatka = new List<GameObject>();
    public GameObject kratkaWody;

    uint wierszy = 10;
    uint kolumn = 10;
    Vector3 tymczasowy;


    private void Start()
    {
        for(int i = 0; i < wierszy; i++)
        {
            for(int j = 0; j < kolumn; j++)
            {
                var temp = Instantiate(kratkaWody);
                tymczasowy = new Vector3(i, 0, j);
                temp.transform.position = tymczasowy;
                temp.name = "Woda_" + i + "-" + j;
                //siatka.Add(temp);
                
            }


        }



    }

}
