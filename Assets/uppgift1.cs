using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppgift1 : MonoBehaviour {

    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float tal;
    public float rotenur;
    public float arenavrektangeln;
    public float angle;
    public float pieces;
    public string name;
    public float radius;
    public int damage;
    public int demonHp;
    public int antaletDemon;
    public int minstaskada;
    public int störstaskada;
    public float count;
    public float countMulti;
    public float playerMaxLife;
    public float playerResist;
    public float enemyDamage;



    void förstauppgiften()
    {

        Debug.Log("Uppgift1: " + ((963d * 421d) - (175463d / 87d)));

    }
    void uppgift2()
    {
        Debug.Log("uppgift 2 " + (sentence1));
        Debug.Log("uppgift 2 " + (sentence2));
        Debug.Log(("uppgift 2 " + sentence3));

    }
    void uppgift3()
    {

        Debug.Log(("uppgift3: ") + (Mathf.Pow(tal, 2)));
        Debug.Log(("uppgift3: ") + Mathf.Sqrt(rotenur));
    }
    void uppgift4()
    {
        Debug.Log("uppgift 4 " + 8 * (arenavrektangeln) / 2 + "m^2");

    }
    void uppgift5()
    {
        Debug.Log(("uppgift 5a ") + (360 / (angle) + " tårtbitar "));
        Debug.Log("uppgift 5b " + 360 / (pieces) + " grader ");

    }
    void uppgift6()
    {

        Debug.Log("uppgift 6 " + "EL " + (name) + " OF DOOOOOM ");
    }
    void uppgift7()
    {
        Debug.Log("uppgift 7 " + 4 * Mathf.PI * (Mathf.Pow(radius, 3) / 3 * 2978));


    }
    void uppgift8()
    {
        Debug.Log("uppgift 8a/b " + ((antaletDemon) * (demonHp) / (damage)));
        Debug.Log("uppgift 8c min" + antaletDemon * demonHp / minstaskada);
        Debug.Log("uppgift 8c max" + antaletDemon * demonHp / störstaskada);
        Debug.Log("uppgift 8c average" + antaletDemon * demonHp / minstaskada + störstaskada / 2);
        Debug.Log(("uppgift 8extra ") + (antaletDemon * demonHp / Random.Range(störstaskada, minstaskada)));

    }
    void uppgift9()
    {

        count = count * 2;
        Debug.Log("uppgift9 " + count);
    }
    void uppgift10()
    {
        countMulti = countMulti * 3 / 2;
        Debug.Log("uppgift10 " + countMulti);

    }
    void uppgift11()
    {
        playerMaxLife = enemyDamage * playerResist;
        Debug.Log("uppgift11 " + playerMaxLife);

    }
    
    // Use this for initialization
	void Start () {

        förstauppgiften();
        uppgift2();
        uppgift3();
        uppgift4();
        uppgift5();
        uppgift6();
        uppgift7();
        uppgift8();
        uppgift10();
        uppgift11();
       

       }
	
	// Update is called once per frame
	void Update () {

        //uppgift9();

    }
}
