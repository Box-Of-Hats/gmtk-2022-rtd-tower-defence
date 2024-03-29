﻿using gmtkjame2022rollthedice.Models;
using gmtkjame2022rollthedice.Helpers;
using System.Collections.Generic;

namespace gmtkjame2022rollthedice.Data
{
    public static class Enemies
    {
        public static Dictionary<int, EnemyModel> All = new Dictionary<int, EnemyModel>()
        {
            {
                1,  new EnemyModel()
               {
                    SpriteTexture = Helpers.Helpers.LoadTextureFromImagePath("res://sprites/enemy-001.png"),
                    MoveSpeed = 100
                }
            },
            {
                2, new EnemyModel()
                {
                    SpriteTexture = Helpers.Helpers.LoadTextureFromImagePath("res://sprites/enemy-002.png"),
                    MoveSpeed= 100,
                    HealthMultiplier = 1.5f
                }
            },
            {
                3, new EnemyModel()
                {
                    SpriteTexture = Helpers.Helpers.LoadTextureFromImagePath("res://sprites/enemy-003.png"),
                    MoveSpeed = 400,
                    HealthMultiplier = 0.7f
                }
            },
            {
                4, new EnemyModel()
                {
                    SpriteTexture = Helpers.Helpers.LoadTextureFromImagePath("res://sprites/enemy-004.png"),
                    MoveSpeed = 150,
                    HealthMultiplier = 5f
                }
            },
            {
                5, new EnemyModel()
                {
                    SpriteTexture = Helpers.Helpers.LoadTextureFromImagePath("res://sprites/enemy-005.png"),
                    MoveSpeed = 300,
                    HealthMultiplier = 3f
                }
            }
        };

    }
}
