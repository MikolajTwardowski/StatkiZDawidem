using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerStrzelania : MonoBehaviour
{
    //Mapa mapa;

    GameObject trafiony;
    public GameObject trafionaKomorka;

    private void Start()
    {
        //mapa = gameObject.GetComponent<Mapa>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit trafienie;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out trafienie);
            if (trafienie.collider != null)
            {
                trafiony = trafienie.collider.gameObject;
                //var temp = Instantiate(trafionaKomorka, trafiony.transform);
                //temp.name = "Tak" + temp.transform.position.x + "-" + temp.transform.position.z;
                //Debug.Log(temp.name);
                //mapa.siatka.Remove(trafiony);
                Destroy(trafiony);
            }
            else
                Debug.Log("No nie trafiło");
        }


    }

}
