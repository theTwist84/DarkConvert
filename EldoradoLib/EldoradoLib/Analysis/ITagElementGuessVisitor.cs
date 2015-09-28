﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoLib.Analysis
{
	/// <summary>
	/// Interface for a class which can visit tag element guesses.
	/// </summary>
	public interface ITagElementGuessVisitor
	{
		void Visit(uint offset, TagBlockGuess guess);
		void Visit(uint offset, DataReferenceGuess guess);
		void Visit(uint offset, TagReferenceGuess guess);
		void Visit(uint offset, ResourceReferenceGuess guess);
	}
}
