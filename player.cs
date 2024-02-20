using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2.BL
{
    internal class player
    {
        public string name;
        public double hp;
        public double maxHp=100;
        public double energy;
        public double maxEnergy=100;
        public double  armour;
        public stats skillStatistics;

        public player() { }
        public player(string n,double h,double e,double a)
        {
            name = n;
            hp=h;
            energy = e;
            armour = a;

        }
        public player(string n, double h,double mh,double e, double me, double a)
        {
            name = n;
            hp = h;
            maxHp = mh;
            energy = e;
            maxEnergy = me;
            armour = a;

        }

        public void updateHealth(double amount)
        {
            hp -= amount;
            if (hp > maxHp)
                hp = maxHp;
            else if (hp < 0)
                hp = 0;
        }

        public void updateEnergy(double amount)
        {
            energy -= amount;
            if (energy > maxEnergy)
                energy = maxEnergy;
            else if (energy < 0)
                energy = 0;
        }

        public void updateArmor(double amount)
        {
            armour -= amount;
            if (armour < 0)
                armour = 0;
        }

        public void updateName(string newName)
        {
            name = newName;
        }

        public void learnSkill(stats s)
        {
            skillStatistics = s;

        }
        public string attack(player target)
        {
            double effectiveArmor =  target.armour - skillStatistics.penetration;
            double damageDealt = skillStatistics.damage * ((100 - target.armour) / 100);

            if (skillStatistics.cost > energy)
                return $"{name} attempted to use {skillStatistics.name}, but didn't have enough energy!";

            energy -= skillStatistics.cost;
            target.updateHealth(damageDealt);
            updateHealth(skillStatistics.heal);

            string attackString = $"{name} used {skillStatistics.name}, {skillStatistics.description}, against {target.name}, doing {damageDealt:F2} damage!";
            if (skillStatistics.heal > 0)
                attackString += $" {name} healed for {skillStatistics.heal} health!";

            if (target.hp <= 0)
                attackString += $" {target.name} died.";
            else
                attackString += $" {target.name} is at {target.hp / target.maxHp * 100:F2}% health.";

            return attackString;
        }
    }
}
