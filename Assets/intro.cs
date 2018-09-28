using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    // Hejsan = Namnet
   // Public = finns i UNity
   // Int = heltal 
    public int hejdå;

    // float = decimaltal med 7 precision.
    public float boris;

    // double = decimaltal med 15 precistion.
    public double obama;

    //  String = Text
    public string minecraft;

    // Bool = något som är true/false (ja/nej)
    public bool indianenjonas;

    /* Multi-line comment eller lång comment 
     * Hej
     * På
     * Mig
     */

        // Ett tecken 
    public char izard;
    private string john;


    // Use this for initialization
    void Start()
    {
        // PrintText();
        // Calculate();
        Debug.Log("Hej" + "då!" + "john" + " " + minecraft);
        Debug.Log(string.Format("Hej då! {0} {1}", john, minecraft));
    }

    //ALTGR + 7
    // ALT + CTRL + 7 
    void PrintText()
    {
        Debug.Log(minecraft);
        Debug.Log(hejdå + boris);
        Debug.Log(13 * (7f + 4));
        Debug.LogError(77 + 99 + 1);
        //Debug.LogError(
            //Mathf.Sqrt(54546) +
            //Mathf.Sqrt(41435));
    }

    void Calculate()
    {
        Debug.Log(5 + 5);
        Debug.Log(11 / 2f);

    }

    // Update is called once per frame
    void Update()
    {
        //- Debug.Log(5);
    }
}
