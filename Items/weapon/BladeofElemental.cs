using System;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace Elemental.Items
{
    public class BladeofElemental : ModItem
   public override void UseItemEffects(Player player, Rectangle rectangle)
	{
            int dust = Dust.NewDust(new Vector2((float) rectangle.X, (float) rectangle.Y), rectangle.Width, rectangle.Height, 6, player.velocity.X, player.velocity.Y, 100, Color.White, 1f);
            Main.dust[dust].noGravity = true;
	}
}
