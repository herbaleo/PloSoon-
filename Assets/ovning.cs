using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovning : MonoBehaviour {

    public int userValue;
    public int dice1;
    public int dice2;
    public int aftervalue;
    public int startvalue;
    public int playerDmg;
    public int drakeHp;
    public int playerHp;
    public int dragonHitchance;
   public int dragonDmg;
    public int dragonHpAfterValue;
    public int playerHpAfterValue;
    public int dragonExtraHp;
    public int dragonExtraHpChance;
    public int playerMaxDmg;
    public int playerMinDmg;
    public int playerCrit;
    public int playerCritChance;
    public int guessGameStartValue;
    public int playerGuess;
    public int playerGuessHigher;
    public int playerGuessLower;
    public int guessValue;
    public int ggAfterValue;
    public int lastGuessValue;
    public int WinStreak;
    public int WinStreakStart;
    public int WinStreakLast;
    
    
    // Use this for initialization
	void Start () {
           startvalue = 10;
            aftervalue = startvalue;
        dragonExtraHp = drakeHp;
        dragonExtraHpChance = Random.Range(1, 11);

        if (dragonExtraHpChance == 10)
        {
            drakeHp = drakeHp + dragonExtraHp;
        }
        drakeHp =  Random.Range(100, 150);
        playerHp = 100;
        dragonHpAfterValue = drakeHp;
        playerHpAfterValue = playerHp;

        guessGameStartValue = 50;
        guessValue = guessGameStartValue;
        lastGuessValue = guessValue;
        WinStreakStart = 0;
        WinStreak = WinStreakStart;
        WinStreakLast = WinStreak;
        print(guessGameStartValue);
       



    }

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = (userValue + 2);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = (userValue / 2);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
            
        }

        
        if (Input.GetKeyDown(KeyCode.R))
        {
            dice1 = Random.Range(1, 7);
            dice2 = Random.Range(1, 7);

            aftervalue = aftervalue + dice1 - dice2;
            

           print(aftervalue);

            if (aftervalue >= 20)
            {
                print("Victory Royale");
            }
            if (aftervalue <= 0)
            {
                print("You Lose");
            }
            if (aftervalue <=19)
            {
                print("try again");
            }
            
            
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (dragonHpAfterValue + playerHpAfterValue >= 0)
            {
                playerMinDmg = Random.Range(1, 11);
                playerMaxDmg = Random.Range(20, 31);
                playerDmg = Random.Range(playerMinDmg, playerMaxDmg);
                playerCritChance = Random.Range(1, 21);
                playerCrit = dragonHpAfterValue;
                dragonHpAfterValue = dragonHpAfterValue - playerDmg;
                print("DragonHp " + dragonHpAfterValue);
                dragonDmg = Random.Range(10, 21);
                dragonHitchance = Random.Range(1, 3);
                playerHp = playerHp - dragonDmg;
                if (playerCritChance == 1)
                {
                    dragonHpAfterValue = dragonHpAfterValue - playerCrit;
                    print("Player CRITICAL STRIKE");
                }
                else
                {

                }

                if (dragonHitchance == 1)
                {    playerHpAfterValue = playerHpAfterValue - dragonDmg;
                    print("Dragon Hit");

                }
                if (dragonHitchance == 2)
                { 
                dragonDmg = 0;
                    print("Dragon Missed");
                        }

                print("PlayerHp " + playerHpAfterValue);


                if (dragonHpAfterValue <= 0 && (playerHpAfterValue >= 0))
                {
                    print("Victory!");
                }

                if (playerHpAfterValue <= 0 && dragonHpAfterValue >= 0)
                {
                    print("GAME OVER");
                }

                if (playerHpAfterValue <= 0 && dragonHpAfterValue <= 0)
                {
                    print("DRAW");
                }
            }
            else
            {
                print("Restart Game!");
            }

        }

        
        if (Input.GetKeyDown(KeyCode.Y))
        {
            guessValue = Random.Range(1, 101);
            

            if (guessValue >= lastGuessValue) 
            {
                Debug.Log(guessValue);
             print("+ 1 Point");
                

                WinStreak = WinStreak +1;
                print("Win Streak = " + WinStreak);
            }

            else
            {
                //highScoreLast = 0;
                Debug.Log(guessValue);
                print("Wrong Answer");
                WinStreak = 0;
                ;
                
                
            }

        } 
        

   
        if (Input.GetKeyDown(KeyCode.H))
        {
            guessValue = Random.Range(1, 101);

            if (guessValue <= lastGuessValue)
            {
                print("+ 1 Point");
                Debug.Log(guessValue);
                WinStreak = WinStreak + 1;
                print("Win Streak = " + WinStreak);
            }
            else
            {
                Debug.Log(guessValue);
                print("Wrong Answer");
               
                WinStreak = 0;
            }


        }

	}
}
