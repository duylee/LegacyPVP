﻿using RiotRtmpDto.Platform.Catalog.Runes;
using RtmpSharp.IO;
using System;
namespace RiotRtmpDto.Platform.Catalog
{
    [Serializable]
    [SerializedName("com.riotgames.platform.catalog.Effect")]
    public class Effect
    {
        [SerializedName("effectId")]
        public Int32 EffectId { get; set; }

        [SerializedName("gameCode")]
        public String GameCode { get; set; }

        [SerializedName("name")]
        public String Name { get; set; }

        [SerializedName("categoryId")]
        public object CategoryId { get; set; }

        [SerializedName("runeType")]
        public RuneType RuneType { get; set; }
    }
}
