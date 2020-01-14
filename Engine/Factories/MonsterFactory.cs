﻿using Engine.Models;
using System;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake = new Monster(name: "Snake", imageName: "Snake.png", maximumHitPoints: 4,
                      hitPoints: 4, minimumDamage: 1, maximumDamage: 2, rewardExperiencePoints: 5, rewardGold: 1);

                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    return snake;

                case 2:
                    Monster rat = new Monster(name: "Rat", imageName: "Rat.png", maximumHitPoints: 4, hitPoints: 4,
                        minimumDamage: 1, maximumDamage: 2, rewardExperiencePoints: 5, rewardGold: 1);

                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);

                    return rat;

                case 3:
                    Monster giantSpider = new Monster(name: "Giant Spider", imageName: "GiantSpider.png", maximumHitPoints: 10, hitPoints: 10,
                    minimumDamage: 1, maximumDamage: 4, rewardExperiencePoints: 10, rewardGold: 3);

                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    return giantSpider;

                default:
                    throw new ArgumentException(string.Format("MonsteType'{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}