using System;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace Elemental.Items
{
public class PickaxeofElemental : ModItem
	{
	public override void UseItemEffects(Player player, Rectangle rectangle)
		{
            int dust = Dust.NewDust(new Vector2((float) rectangle.X, (float) rectangle.Y), rectangle.Width, rectangle.Height, 75, player.velocity.X, player.velocity.Y, 100, Color.Gold, 1f);
            Main.dust[dust].noGravity = true;
		}
	}
}