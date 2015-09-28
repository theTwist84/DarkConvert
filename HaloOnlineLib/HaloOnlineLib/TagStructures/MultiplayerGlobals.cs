using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "mulg", Size = 0x18)]
	public class MultiplayerGlobals
	{
		[TagElement]
		public List<UniversalGlobals> Universal { get; set; }
		[TagElement]
		public List<RuntimeGlobals> Runtime { get; set; }

		[TagStructure(Size = 0xD0)]
		public class UniversalGlobals
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown10 { get; set; }
			[TagElement]
			public List<TagBlock1> Unknown20 { get; set; }
			[TagElement]
			public List<TagBlock2> Unknown2C { get; set; }
			[TagElement]
			public HaloTag Unknown38 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public int Unknown50 { get; set; }
			[TagElement]
			public int Unknown54 { get; set; }
			[TagElement]
			public int Unknown58 { get; set; }
			[TagElement]
			public int Unknown5C { get; set; }
			[TagElement]
			public int Unknown60 { get; set; }
			[TagElement]
			public int Unknown64 { get; set; }
			[TagElement]
			public List<TagBlock3> Unknown68 { get; set; }
			[TagElement]
			public List<TagBlock4> Unknown74 { get; set; }
			[TagElement]
			public List<TagBlock5> Unknown80 { get; set; }
			[TagElement]
			public HaloTag Unknown8C { get; set; }
			[TagElement]
			public List<TagBlock6> Unknown9C { get; set; }
			[TagElement]
			public List<TagBlock8> UnknownA8 { get; set; }
			[TagElement]
			public List<TagBlock10> UnknownB4 { get; set; }
			[TagElement]
			public HaloTag UnknownC0 { get; set; }

			[TagStructure(Size = 0x18)]
			public class TagBlock1
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public HaloTag Unknown4 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
			}

			[TagStructure(Size = 0x8)]
			public class TagBlock2
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x18)]
			public class TagBlock3
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public HaloTag Unknown8 { get; set; }
			}

			[TagStructure(Size = 0x14)]
			public class TagBlock4
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public HaloTag Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x14)]
			public class TagBlock5
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public HaloTag Unknown4 { get; set; }
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock6
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock7> Unknown4 { get; set; }

				[TagStructure(Size = 0x8)]
				public class TagBlock7
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
				}
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock8
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public List<TagBlock9> Unknown4 { get; set; }

				[TagStructure(Size = 0x8)]
				public class TagBlock9
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
				}
			}

			[TagStructure(Size = 0x40)]
			public class TagBlock10
			{
				[TagElement]
				public HaloTag Unknown0 { get; set; }
				[TagElement]
				public HaloTag Unknown10 { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public List<TagBlock11> Unknown28 { get; set; }
				[TagElement]
				public List<TagBlock12> Unknown34 { get; set; }

				[TagStructure(Size = 0x34)]
				public class TagBlock11
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
					[TagElement]
					public int Unknown8 { get; set; }
					[TagElement]
					public int UnknownC { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
					[TagElement]
					public int Unknown14 { get; set; }
					[TagElement]
					public int Unknown18 { get; set; }
					[TagElement]
					public int Unknown1C { get; set; }
					[TagElement]
					public int Unknown20 { get; set; }
					[TagElement]
					public int Unknown24 { get; set; }
					[TagElement]
					public int Unknown28 { get; set; }
					[TagElement]
					public int Unknown2C { get; set; }
					[TagElement]
					public int Unknown30 { get; set; }
				}

				[TagStructure(Size = 0x58)]
				public class TagBlock12
				{
					[TagElement]
					public int Unknown0 { get; set; }
					[TagElement]
					public int Unknown4 { get; set; }
					[TagElement]
					public int Unknown8 { get; set; }
					[TagElement]
					public int UnknownC { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
					[TagElement]
					public int Unknown14 { get; set; }
					[TagElement]
					public int Unknown18 { get; set; }
					[TagElement]
					public int Unknown1C { get; set; }
					[TagElement]
					public int Unknown20 { get; set; }
					[TagElement]
					public int Unknown24 { get; set; }
					[TagElement]
					public int Unknown28 { get; set; }
					[TagElement]
					public int Unknown2C { get; set; }
					[TagElement]
					public HaloTag Unknown30 { get; set; }
					[TagElement]
					public HaloTag Unknown40 { get; set; }
					[TagElement]
					public int Unknown50 { get; set; }
					[TagElement]
					public int Unknown54 { get; set; }
				}
			}
		}

		[TagStructure(Size = 0x308)]
		public class RuntimeGlobals
		{
			[TagElement]
			public HaloTag Unknown0 { get; set; }
			[TagElement]
			public HaloTag Unknown10 { get; set; }
			[TagElement]
			public HaloTag Unknown20 { get; set; }
			[TagElement]
			public int Unknown30 { get; set; }
			[TagElement]
			public int Unknown34 { get; set; }
			[TagElement]
			public int Unknown38 { get; set; }
			[TagElement]
			public int Unknown3C { get; set; }
			[TagElement]
			public int Unknown40 { get; set; }
			[TagElement]
			public int Unknown44 { get; set; }
			[TagElement]
			public int Unknown48 { get; set; }
			[TagElement]
			public int Unknown4C { get; set; }
			[TagElement]
			public HaloTag Unknown50 { get; set; }
			[TagElement]
			public HaloTag Unknown60 { get; set; }
			[TagElement]
			public HaloTag Unknown70 { get; set; }
			[TagElement]
			public HaloTag Unknown80 { get; set; }
			[TagElement]
			public HaloTag Unknown90 { get; set; }
			[TagElement]
			public HaloTag UnknownA0 { get; set; }
			[TagElement]
			public HaloTag UnknownB0 { get; set; }
			[TagElement]
			public List<TagBlock14> UnknownC0 { get; set; }
			[TagElement]
			public List<TagBlock15> UnknownCC { get; set; }
			[TagElement]
			public List<TagBlock16> UnknownD8 { get; set; }
			[TagElement]
			public List<TagBlock17> UnknownE4 { get; set; }
			[TagElement]
			public List<TagBlock18> UnknownF0 { get; set; }
			[TagElement]
			public List<TagBlock19> UnknownFC { get; set; }
			[TagElement]
			public List<TagBlock20> Unknown108 { get; set; }
			[TagElement]
			public List<TagBlock21> Unknown114 { get; set; }
			[TagElement]
			public List<TagBlock22> Unknown120 { get; set; }
			[TagElement]
			public List<TagBlock23> Unknown12C { get; set; }
			[TagElement]
			public List<TagBlock24> Unknown138 { get; set; }
			[TagElement]
			public List<TagBlock25> Unknown144 { get; set; }
			[TagElement]
			public List<TagBlock26> Unknown150 { get; set; }
			[TagElement]
			public List<TagBlock27> Unknown15C { get; set; }
			[TagElement]
			public int Unknown168 { get; set; }
			[TagElement]
			public int Unknown16C { get; set; }
			[TagElement]
			public List<TagBlock28> Unknown170 { get; set; }
			[TagElement]
			public List<TagBlock33> Unknown17C { get; set; }
			[TagElement]
			public HaloTag Unknown188 { get; set; }
			[TagElement]
			public HaloTag Unknown198 { get; set; }
			[TagElement]
			public HaloTag Unknown1A8 { get; set; }
			[TagElement]
			public int Unknown1B8 { get; set; }
			[TagElement]
			public int Unknown1BC { get; set; }
			[TagElement]
			public int Unknown1C0 { get; set; }
			[TagElement]
			public int Unknown1C4 { get; set; }
			[TagElement]
			public int Unknown1C8 { get; set; }
			[TagElement]
			public int Unknown1CC { get; set; }
			[TagElement]
			public int Unknown1D0 { get; set; }
			[TagElement]
			public int Unknown1D4 { get; set; }
			[TagElement]
			public HaloTag Unknown1D8 { get; set; }
			[TagElement]
			public HaloTag Unknown1E8 { get; set; }
			[TagElement]
			public HaloTag Unknown1F8 { get; set; }
			[TagElement]
			public HaloTag Unknown208 { get; set; }
			[TagElement]
			public HaloTag Unknown218 { get; set; }
			[TagElement]
			public HaloTag Unknown228 { get; set; }
			[TagElement]
			public HaloTag Unknown238 { get; set; }
			[TagElement]
			public int Unknown248 { get; set; }
			[TagElement]
			public int Unknown24C { get; set; }
			[TagElement]
			public int Unknown250 { get; set; }
			[TagElement]
			public int Unknown254 { get; set; }
			[TagElement]
			public HaloTag Unknown258 { get; set; }
			[TagElement]
			public HaloTag Unknown268 { get; set; }
			[TagElement]
			public HaloTag Unknown278 { get; set; }
			[TagElement]
			public HaloTag Unknown288 { get; set; }
			[TagElement]
			public HaloTag Unknown298 { get; set; }
			[TagElement]
			public HaloTag Unknown2A8 { get; set; }
			[TagElement]
			public HaloTag Unknown2B8 { get; set; }
			[TagElement]
			public HaloTag Unknown2C8 { get; set; }
			[TagElement]
			public HaloTag Unknown2D8 { get; set; }
			[TagElement]
			public HaloTag Unknown2E8 { get; set; }
			[TagElement]
			public HaloTag Unknown2F8 { get; set; }

			[TagStructure(Size = 0x10)]
			public class TagBlock14
			{
				[TagElement]
				public HaloTag Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x10)]
			public class TagBlock15
			{
				[TagElement]
				public HaloTag Unknown0 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock16
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock17
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public HaloTag Unknown13C { get; set; }
				[TagElement]
				public HaloTag Unknown14C { get; set; }
				[TagElement]
				public HaloTag Unknown15C { get; set; }
				[TagElement]
				public HaloTag Unknown16C { get; set; }
				[TagElement]
				public HaloTag Unknown17C { get; set; }
				[TagElement]
				public HaloTag Unknown18C { get; set; }
				[TagElement]
				public HaloTag Unknown19C { get; set; }
				[TagElement]
				public HaloTag Unknown1AC { get; set; }
				[TagElement]
				public HaloTag Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public HaloTag Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock18
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public HaloTag Unknown13C { get; set; }
				[TagElement]
				public HaloTag Unknown14C { get; set; }
				[TagElement]
				public HaloTag Unknown15C { get; set; }
				[TagElement]
				public HaloTag Unknown16C { get; set; }
				[TagElement]
				public HaloTag Unknown17C { get; set; }
				[TagElement]
				public HaloTag Unknown18C { get; set; }
				[TagElement]
				public HaloTag Unknown19C { get; set; }
				[TagElement]
				public HaloTag Unknown1AC { get; set; }
				[TagElement]
				public HaloTag Unknown1BC { get; set; }
				[TagElement]
				public HaloTag Unknown1CC { get; set; }
				[TagElement]
				public HaloTag Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock19
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock20
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock21
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock22
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock23
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock24
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock25
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock26
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x20C)]
			public class TagBlock27
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public int Unknown68 { get; set; }
				[TagElement]
				public int Unknown6C { get; set; }
				[TagElement]
				public int Unknown70 { get; set; }
				[TagElement]
				public int Unknown74 { get; set; }
				[TagElement]
				public int Unknown78 { get; set; }
				[TagElement]
				public int Unknown7C { get; set; }
				[TagElement]
				public int Unknown80 { get; set; }
				[TagElement]
				public int Unknown84 { get; set; }
				[TagElement]
				public int Unknown88 { get; set; }
				[TagElement]
				public int Unknown8C { get; set; }
				[TagElement]
				public int Unknown90 { get; set; }
				[TagElement]
				public int Unknown94 { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public int Unknown164 { get; set; }
				[TagElement]
				public int Unknown168 { get; set; }
				[TagElement]
				public int Unknown16C { get; set; }
				[TagElement]
				public int Unknown170 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public int Unknown184 { get; set; }
				[TagElement]
				public int Unknown188 { get; set; }
				[TagElement]
				public int Unknown18C { get; set; }
				[TagElement]
				public int Unknown190 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public int Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1A8 { get; set; }
				[TagElement]
				public int Unknown1AC { get; set; }
				[TagElement]
				public int Unknown1B0 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public int Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1C8 { get; set; }
				[TagElement]
				public int Unknown1CC { get; set; }
				[TagElement]
				public int Unknown1D0 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
			}

			[TagStructure(Size = 0x220)]
			public class TagBlock28
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
				[TagElement]
				public int Unknown24 { get; set; }
				[TagElement]
				public int Unknown28 { get; set; }
				[TagElement]
				public int Unknown2C { get; set; }
				[TagElement]
				public int Unknown30 { get; set; }
				[TagElement]
				public int Unknown34 { get; set; }
				[TagElement]
				public int Unknown38 { get; set; }
				[TagElement]
				public int Unknown3C { get; set; }
				[TagElement]
				public int Unknown40 { get; set; }
				[TagElement]
				public int Unknown44 { get; set; }
				[TagElement]
				public int Unknown48 { get; set; }
				[TagElement]
				public int Unknown4C { get; set; }
				[TagElement]
				public int Unknown50 { get; set; }
				[TagElement]
				public int Unknown54 { get; set; }
				[TagElement]
				public int Unknown58 { get; set; }
				[TagElement]
				public int Unknown5C { get; set; }
				[TagElement]
				public int Unknown60 { get; set; }
				[TagElement]
				public int Unknown64 { get; set; }
				[TagElement]
				public List<TagBlock29> Unknown68 { get; set; }
				[TagElement]
				public List<TagBlock30> Unknown74 { get; set; }
				[TagElement]
				public List<TagBlock31> Unknown80 { get; set; }
				[TagElement]
				public List<TagBlock32> Unknown8C { get; set; }
				[TagElement]
				public int Unknown98 { get; set; }
				[TagElement]
				public int Unknown9C { get; set; }
				[TagElement]
				public int UnknownA0 { get; set; }
				[TagElement]
				public int UnknownA4 { get; set; }
				[TagElement]
				public int UnknownA8 { get; set; }
				[TagElement]
				public int UnknownAC { get; set; }
				[TagElement]
				public int UnknownB0 { get; set; }
				[TagElement]
				public int UnknownB4 { get; set; }
				[TagElement]
				public int UnknownB8 { get; set; }
				[TagElement]
				public int UnknownBC { get; set; }
				[TagElement]
				public int UnknownC0 { get; set; }
				[TagElement]
				public int UnknownC4 { get; set; }
				[TagElement]
				public int UnknownC8 { get; set; }
				[TagElement]
				public int UnknownCC { get; set; }
				[TagElement]
				public int UnknownD0 { get; set; }
				[TagElement]
				public int UnknownD4 { get; set; }
				[TagElement]
				public int UnknownD8 { get; set; }
				[TagElement]
				public int UnknownDC { get; set; }
				[TagElement]
				public int UnknownE0 { get; set; }
				[TagElement]
				public int UnknownE4 { get; set; }
				[TagElement]
				public int UnknownE8 { get; set; }
				[TagElement]
				public int UnknownEC { get; set; }
				[TagElement]
				public int UnknownF0 { get; set; }
				[TagElement]
				public int UnknownF4 { get; set; }
				[TagElement]
				public int UnknownF8 { get; set; }
				[TagElement]
				public int UnknownFC { get; set; }
				[TagElement]
				public int Unknown100 { get; set; }
				[TagElement]
				public int Unknown104 { get; set; }
				[TagElement]
				public int Unknown108 { get; set; }
				[TagElement]
				public int Unknown10C { get; set; }
				[TagElement]
				public int Unknown110 { get; set; }
				[TagElement]
				public int Unknown114 { get; set; }
				[TagElement]
				public int Unknown118 { get; set; }
				[TagElement]
				public int Unknown11C { get; set; }
				[TagElement]
				public int Unknown120 { get; set; }
				[TagElement]
				public int Unknown124 { get; set; }
				[TagElement]
				public int Unknown128 { get; set; }
				[TagElement]
				public int Unknown12C { get; set; }
				[TagElement]
				public int Unknown130 { get; set; }
				[TagElement]
				public int Unknown134 { get; set; }
				[TagElement]
				public int Unknown138 { get; set; }
				[TagElement]
				public int Unknown13C { get; set; }
				[TagElement]
				public int Unknown140 { get; set; }
				[TagElement]
				public int Unknown144 { get; set; }
				[TagElement]
				public int Unknown148 { get; set; }
				[TagElement]
				public int Unknown14C { get; set; }
				[TagElement]
				public int Unknown150 { get; set; }
				[TagElement]
				public int Unknown154 { get; set; }
				[TagElement]
				public int Unknown158 { get; set; }
				[TagElement]
				public int Unknown15C { get; set; }
				[TagElement]
				public int Unknown160 { get; set; }
				[TagElement]
				public HaloTag Unknown164 { get; set; }
				[TagElement]
				public int Unknown174 { get; set; }
				[TagElement]
				public int Unknown178 { get; set; }
				[TagElement]
				public int Unknown17C { get; set; }
				[TagElement]
				public int Unknown180 { get; set; }
				[TagElement]
				public HaloTag Unknown184 { get; set; }
				[TagElement]
				public int Unknown194 { get; set; }
				[TagElement]
				public int Unknown198 { get; set; }
				[TagElement]
				public int Unknown19C { get; set; }
				[TagElement]
				public int Unknown1A0 { get; set; }
				[TagElement]
				public HaloTag Unknown1A4 { get; set; }
				[TagElement]
				public int Unknown1B4 { get; set; }
				[TagElement]
				public int Unknown1B8 { get; set; }
				[TagElement]
				public int Unknown1BC { get; set; }
				[TagElement]
				public int Unknown1C0 { get; set; }
				[TagElement]
				public HaloTag Unknown1C4 { get; set; }
				[TagElement]
				public int Unknown1D4 { get; set; }
				[TagElement]
				public int Unknown1D8 { get; set; }
				[TagElement]
				public int Unknown1DC { get; set; }
				[TagElement]
				public int Unknown1E0 { get; set; }
				[TagElement]
				public int Unknown1E4 { get; set; }
				[TagElement]
				public int Unknown1E8 { get; set; }
				[TagElement]
				public int Unknown1EC { get; set; }
				[TagElement]
				public int Unknown1F0 { get; set; }
				[TagElement]
				public int Unknown1F4 { get; set; }
				[TagElement]
				public int Unknown1F8 { get; set; }
				[TagElement]
				public int Unknown1FC { get; set; }
				[TagElement]
				public int Unknown200 { get; set; }
				[TagElement]
				public int Unknown204 { get; set; }
				[TagElement]
				public int Unknown208 { get; set; }
				[TagElement]
				public int Unknown20C { get; set; }
				[TagElement]
				public int Unknown210 { get; set; }
				[TagElement]
				public int Unknown214 { get; set; }
				[TagElement]
				public int Unknown218 { get; set; }
				[TagElement]
				public int Unknown21C { get; set; }

				[TagStructure(Size = 0x20)]
				public class TagBlock29
				{
					[TagElement]
					public HaloTag Unknown0 { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
					[TagElement]
					public int Unknown14 { get; set; }
					[TagElement]
					public int Unknown18 { get; set; }
					[TagElement]
					public int Unknown1C { get; set; }
				}

				[TagStructure(Size = 0x20)]
				public class TagBlock30
				{
					[TagElement]
					public HaloTag Unknown0 { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
					[TagElement]
					public int Unknown14 { get; set; }
					[TagElement]
					public int Unknown18 { get; set; }
					[TagElement]
					public int Unknown1C { get; set; }
				}

				[TagStructure(Size = 0x1C)]
				public class TagBlock31
				{
					[TagElement]
					public HaloTag Unknown0 { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
					[TagElement]
					public int Unknown14 { get; set; }
					[TagElement]
					public int Unknown18 { get; set; }
				}

				[TagStructure(Size = 0x14)]
				public class TagBlock32
				{
					[TagElement]
					public HaloTag Unknown0 { get; set; }
					[TagElement]
					public int Unknown10 { get; set; }
				}
			}

			[TagStructure(Size = 0x24)]
			public class TagBlock33
			{
				[TagElement]
				public int Unknown0 { get; set; }
				[TagElement]
				public int Unknown4 { get; set; }
				[TagElement]
				public int Unknown8 { get; set; }
				[TagElement]
				public int UnknownC { get; set; }
				[TagElement]
				public int Unknown10 { get; set; }
				[TagElement]
				public int Unknown14 { get; set; }
				[TagElement]
				public int Unknown18 { get; set; }
				[TagElement]
				public int Unknown1C { get; set; }
				[TagElement]
				public int Unknown20 { get; set; }
			}
		}
	}
}
