﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MathInfection
{
    class Bullet : ICharacter
    {
        private readonly Texture2D texture;
        private Vector2 position;
        private Vector2 characterSize;
        private Vector2 windowSize;
        private Vector2 playerPosition;
        private readonly int bulletSpeed;
        private readonly int bulletDamage;
        private bool isValid;

        public Bullet(Texture2D tex, Vector2 pos, Vector2 cSize, Vector2 wSize, Vector2 playerPos, int bSpeed, int bDamage)
        {
            texture = tex;
            position = pos;
            characterSize = cSize;
            windowSize = wSize;
            playerPosition = playerPos;
            bulletSpeed = bSpeed;
            bulletDamage = bDamage;
            isValid = true;
        }

        public Vector2 CharacterSize
        {
            get
            {
                return characterSize;
            }
        }

        public Vector2 WindowSize
        {
            get
            {
                return windowSize;
            }
        }

        public Vector2 PlayerPosition
        {
            get
            {
                return playerPosition;
            }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        public void update(Vector2 playerPos)
        {
            position.Y -= bulletSpeed;
            if(position.Y + characterSize.Y/2 < 0)
            {
                isValid = false;
            }
        }

        public void draw(SpriteBatch sb)
        {
            sb.Draw(texture, position, Color.White);
        }
    }
}
