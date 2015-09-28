using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineLib.Serialization;

namespace HaloOnlineLib.TagStructures
{
	[TagStructure(Class = "<fx>", Size = 0x20)]
	public class SoundEffectTemplate
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
		public List<TagBlock0> Unknown10 { get; set; }
		[TagElement]
		public int Unknown1C { get; set; }

		[TagStructure(Size = 0x1C)]
		public class TagBlock0
		{
			[TagElement]
			public int Unknown0 { get; set; }
			[TagElement]
			public byte[] Unknown4 { get; set; }
			[TagElement]
			public int Unknown18 { get; set; }
		}
	}
}
