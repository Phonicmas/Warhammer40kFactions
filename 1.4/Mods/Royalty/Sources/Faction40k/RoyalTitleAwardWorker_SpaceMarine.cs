﻿using RimWorld;
using System.Collections.Generic;
using System.Linq;
using Verse;


namespace Faction40k
{
    public class RoyalTitleAwardWorker_SpaceMarine : RoyalTitleAwardWorker
    {
        public override void DoAward(Pawn pawn, Faction faction, RoyalTitleDef currentTitle, RoyalTitleDef newTitle)
        {
            List<GeneDef> astartesPack = AstartesPack();
            for (int i = 0; i < astartesPack.Count(); i++)
            {
                if (!pawn.genes.HasGene(astartesPack[i]))
                {
                    pawn.genes.AddGene(astartesPack[i], true);
                }
            }

            base.DoAward(pawn, faction, currentTitle, newTitle);
        }

        private List<GeneDef> AstartesPack()
        {
            List<GeneDef> genedef = new List<GeneDef>
            {
                Faction40kDefOf.BEWH_SecondaryHeart,
                Faction40kDefOf.BEWH_Ossmodula,
                Faction40kDefOf.BEWH_Biscopea,
                Faction40kDefOf.BEWH_Haemastamen,
                Faction40kDefOf.BEWH_LarramansOrgan,
                Faction40kDefOf.BEWH_CatalepseanNode,
                Faction40kDefOf.BEWH_Preomnor,
                Faction40kDefOf.BEWH_Omophagea,
                Faction40kDefOf.BEWH_MultiLung,
                Faction40kDefOf.BEWH_Occulobe,
                Faction40kDefOf.BEWH_LymansEar,
                Faction40kDefOf.BEWH_SusAnMembrane,
                Faction40kDefOf.BEWH_Melanochrome,
                Faction40kDefOf.BEWH_OoliticKidney,
                Faction40kDefOf.BEWH_Neuroglottis,
                Faction40kDefOf.BEWH_Mucranoid,
                Faction40kDefOf.BEWH_BetchersGland,
                Faction40kDefOf.BEWH_ProgenoidGlands,
                Faction40kDefOf.BEWH_BlackCarapace
            };
            return genedef;
        }
    }

}