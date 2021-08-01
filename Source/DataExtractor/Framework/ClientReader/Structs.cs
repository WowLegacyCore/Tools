/*
 * Copyright (C) 2012-2019 CypherCore <http://github.com/CypherCore>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace DataExtractor.Framework.ClientReader
{
    public sealed class CinematicCameraRecord
    {
        public uint Id;
        public float[] Origin = new float[3];
        public uint SoundID;
        public float OriginFacing;
        public uint FileDataID;
    }

    public sealed class GameObjectDisplayInfoRecord
    {
        public uint Id;
        public string ModelName;
        public float[] GeoBox = new float[6];
        public uint FileDataID;
        public ushort ObjectEffectPackageID;
        public float OverrideLootEffectScale;
        public float OverrideNameScale;
    }

    public sealed class LiquidMaterialRecord
    {
        public uint Id;
        public sbyte LVF;
        public sbyte Flags;
    }

    public sealed class LiquidObjectRecord
    {
        public uint Id;
        public float FlowDirection;
        public float FlowSpeed;
        public short LiquidTypeID;
        public byte Fishable;
        public byte Reflection;
    }

    public sealed class LiquidTypeRecord
    {
        public uint Id;
        public string Name;
        public string[] Texture = new string[6];
        public ushort Flags;
        public byte SoundBank;
        public uint SoundID;
        public uint SpellID;
        public float MaxDarkenDepth;
        public float FogDarkenIntensity;
        public float AmbDarkenIntensity;
        public float DirDarkenIntensity;
        public ushort LightID;
        public float ParticleScale;
        public byte ParticleMovement;
        public byte ParticleTexSlots;
        public byte MaterialID;
        public int MinimapStaticCol;
        public byte[] FrameCountTexture = new byte[6];
        public int[] Color = new int[2];
        public float[] Float = new float[18];
        public uint[] Int = new uint[4];
        public float[] Coefficient = new float[4];
    }

    public sealed class MapRecord
    {
        public uint Id;
        public string Directory;
        public string MapName;
        public string MapDescription0;
        public string MapDescription1;
        public string PvpShortDescription;
        public string PvpLongDescription;
        public byte MapType;
        public byte InstanceType;
        public byte ExpansionID;
        public ushort AreaTableID;
        public short LoadingScreenID;
        public short TimeOfDayOverride;
        public short ParentMapID;
        public short CosmeticParentMapID;
        public byte TimeOffset;
        public float MinimapIconScale;
        public short CorpseMapID;
        public byte MaxPlayers;
        public short WindSettingsID;
        public uint ZmpFileDataID;
        public uint[] Flags = new uint[2];
    }
}
