using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace Elemental.Projectiles
{
    public class ElementalArrowProj : ElementalProjectile
    {
        public override void AI()
        {
			projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }

        public override void PostKill() //spawns dust on collision and plays a sound.
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //tile dust
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1);
            for (int m = 0; m < 5; m++) //projectile dust
            {
                int dustID = Dust.NewDust(projectile.position, projectile.width, projectile.height, 30, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, Color.Violet, 1.2f);
            }
        }
    }
}
