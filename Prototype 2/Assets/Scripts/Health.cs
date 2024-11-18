using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class healthSystem{

        public int healthMax = 5;
        public int healthAmount;
        public int _healthAmount
         {get{return healthAmount;}} 
        public healthSystem(int healthMax){
            this.healthMax = healthMax;
            healthAmount = healthMax;
        }

        public int getHealth(){
            return healthAmount;
        }

        public void damage(int damageAmount){
            healthAmount -= damageAmount;
            if (healthAmount <= 0) healthAmount = 0;
        }

        public void regain(int regainAmount){
            healthAmount += regainAmount;
            if (healthAmount >= healthMax) healthAmount = healthMax;
        }


    }



