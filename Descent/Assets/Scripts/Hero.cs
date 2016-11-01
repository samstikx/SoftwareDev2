﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Hero : Actions
{

    /*
        4 classes(warrior, mage, healer, scout) + 2 subclasses(knight/beserker, necromancer/runemaster, 
        thief/? , 

        so select hero / select a class first? then allow them to choose their subclass

    */

    //general stats variable if we can do inheritance + taken damage or fatigue functions

    protected int movement, health, fatigue;                       //standard hero attritbutes

    public Hero() { }

    /* public Hero(int heroClass)
     {
         if (heroClass == 1)
         {
             Warriorclass();
         }
         else if (heroClass == 2)
         {
             MageClass();
         }
         else if (heroClass == 3)
         {
             HealerClass();
         }
         else
         {
             ScoutClass();
         }
     }   */


    public void Fatigued()                                     //taken fatigue point
    {
        fatigue--;
    }

    public void Damaged(int damage)                                     //taken damage point
    {
        health -= damage;
    }

    public void LeoricSelect(bool _isRune)                  //Leoric champion selected + subclass selection added
    {
        Leoric leoricHero = new Leoric(_isRune);
    }

    public void WidowSelect(bool _isRune)
    {
        Widow widowHero = new Widow(_isRune);
    }

    public void AsharianSelect(bool _isSeer)
    {
        Ashrian ashrianHero = new Ashrian(_isSeer);
    }

    public void AvricSelect(bool _isSeer)
    {

    }
}
