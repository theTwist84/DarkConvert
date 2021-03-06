﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EldoradoLib.Analysis;

namespace EldoradoLib.Commands.Tags
{
	class GenerateLayoutsCommand : Command
	{
		private readonly TagCache _cache;
		private readonly FileInfo _fileInfo;
		private readonly StringIdCache _stringIds;

		public GenerateLayoutsCommand(TagCache cache, FileInfo fileInfo, StringIdCache stringIds) : base(
			CommandFlags.Inherit,

			"genlayouts",
			"Generate tag layouts",

			"genlayouts <type> <output dir>",

			"Scans all tags in the file to guess tag layouts.\n" +
			"Layouts will be written to the output directory in the chosen format.\n" +
			"\n" +
			"Supported types: csharp, cpp")
		{
			_cache = cache;
			_fileInfo = fileInfo;
			_stringIds = stringIds;
		}

		public override bool Execute(List<string> args)
		{
			if (args.Count != 2)
				return false;
			var outDir = args[1];
			ITagLayoutWriter writer;
			switch (args[0])
			{
				case "csharp":
					writer = new CSharpClassWriter(_stringIds, outDir);
					break;
				case "cpp":
					writer = new CppStructWriter(_stringIds, outDir);
					break;
				default:
					return false;
			}
			Directory.CreateDirectory(outDir);
			var count = 0;
			using (var stream = _fileInfo.OpenRead())
			{
				foreach (var tagClass in _cache.TagClasses)
				{
					TagLayoutGuess layout = null;
					HaloTag lastTag = null;
					foreach (var tag in _cache.Tags.FindAllByClass(tagClass))
					{
						Console.Write("Analyzing ");
						TagPrinter.PrintTagShort(tag);

						lastTag = tag;
						var analyzer = new TagAnalyzer(_cache, tag);
						var data = _cache.ExtractTag(stream, tag);
						var tagLayout = analyzer.Analyze(data);
						if (layout != null)
							layout.Merge(tagLayout);
						else
							layout = tagLayout;
					}
					if (layout != null && lastTag != null)
					{
						Console.WriteLine("Writing {0} layout", tagClass);
						LayoutGuessWriter.Write(lastTag, layout, writer);
						count++;
					}
				}
			}
			Console.WriteLine("Successfully generated {0} layouts!", count);
			return true;
		}
	}
}
