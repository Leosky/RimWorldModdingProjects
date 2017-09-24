using System;
using UnityEngine;
using RimWorld;

namespace MOAR
{
	internal class Building_DamagedPoisonShipPart : Building_CrashedShipPart
	{
		protected override float PlantHarmRange
		{
			get
			{
				return Mathf.Min(3f + 30f * ((float)this.age / 60000f), 140f);
			}
		}

		protected override int PlantHarmInterval
		{
			get
			{
				float f = 4f - 0.6f * (float)this.age / 60000f;
				return Mathf.Clamp(Mathf.RoundToInt(f), 2, 4);
			}
		}
	}
}
