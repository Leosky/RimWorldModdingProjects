using System;
using Verse;
using RimWorld;

namespace MOAR
{
	class IncidentWorker_DamagedPoisonShipPartCrash : MOAR.IncidentWorker_ShipPartCrash
	{
		private static readonly FloatRange ShrapnelMetal = new IntRange(6, 10);
		private static readonly float PuddleDistanceMax = 45f;
		private static readonly float PuddleSizeMax;
		private static readonly float PuddleCount = 3;

		public override bool TryExecute(IncidentParms parms)
		{
			bool baseReturn = base.TryExecute(parms);
			Map map = (Map)parms.target;

			IncidentWorker_ShipPartCrash.SpawnShrapnel(ThingDefOf.SlagRubble, IncidentWorker_ShipPartCrash.ShrapnelRubble.RandomInRange, intVec, map, angle);

			return baseReturn;
		}

		public static void SpawnToxicPuddle(ThingDef def, int quantity, IntVec3 center, Map map, float angle)
		{
			
		}



		public static void SpawnToxicPuddleAtLocation(à
	}
}
