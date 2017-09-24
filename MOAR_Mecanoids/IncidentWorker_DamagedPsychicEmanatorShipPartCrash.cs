using System;
using Verse;
using RimWorld;

namespace MOAR
{
	internal class IncidentWorker_DamagedPsychicEmanatorShipPartCrash : MOAR.IncidentWorker_ShipPartCrash
	{
		protected override bool CanFireNowSub(IIncidentTarget target)
		{
			Map map = (Map)target;
			return !map.gameConditionManager.ConditionIsActive(GameConditionDefOf.PsychicDrone) && base.CanFireNowSub(target);
		}
	}
}
