using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // We want to reference all the different cars in our game

    // Using square brackets creates an array 
    [SerializeField] private Car[] allRacecarsArray;
    // This is a list
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();

    void Start()
    {
        CheckWhichCarIsCrashed();
    }


    private void CheckWhichCarIsCrashed()
    {
        //Use a FOR LOOP
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecarsArray.Length; selectedCarIndex++)
        {
            if (allRacecarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("CRASHED" + selectedCarIndex);
                Debug.Log("A car has crashed: [" + allRacecarsList[selectedCarIndex].name + "]!");
            }
            //if (allRacecarsList[]);
            {

            }
        }

        // We want to output the names of all our cars at Start
        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[0]);

    }



    public void HelloWorldButton()
    {
        Debug.Log("Hello world from a UI button");
    }


}
