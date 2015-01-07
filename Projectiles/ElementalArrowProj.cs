using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace Elemental.Projectiles
{
    public class ElementalArrowProj : ModProjectile
    {
	public override void AI()
		{
			int dust = Dust.NewDust(new Vector2((float) projectile.position.X, (float) projectile.position.Y), projectile.width, projectile.height, 6, 0, 0, 100, Color.White, 1f);
			Main.dust[dust].noGravity = true;
		}
	}
}
