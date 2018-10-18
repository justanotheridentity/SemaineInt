using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recommence : MonoBehaviour {

    public int [] PositionDesCubes;
    private int i;
    private int a;
    private bool changement;

    public GameObject depart;


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Block") // other =
        {
            other.gameObject.transform.position = new Vector3 ( depart.gameObject.transform.position.x, depart.gameObject.transform.position.y, depart.gameObject.transform.position.z);

            //On executé la fonction avance rapide de l'objet.
        }


        // On prend un cliché du tableau

        int numeroGameObject = int.Parse(other.gameObject.tag);

        PositionDesCubes [0]= numeroGameObject;

        i = 1; //Début du tableau
        a = 1;
        changement = false;
        while (i != 10 ) //10 est le numéro de la vraiable MAX
        {
            if (changement == true)
            {
                if (a != numeroGameObject)
                {
                    PositionDesCubes[i] = a;
                    a = a + 1;
                }
                else if (a == numeroGameObject)
                {
                    break;
                }

            }
            else if (numeroGameObject != 10)
            {
                PositionDesCubes[i] = numeroGameObject + i + 1;
                i = i + 1;
            }
            else if ( (numeroGameObject+i+1) ==10)
            {
                PositionDesCubes[i] = numeroGameObject + i + 1;
                i = i + 1;
                changement = true;
            }

        }



    }
}
