﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldoradoLib.Serialization
{
	/// <summary>
	/// A context for serializing or deserializing tag data.
	/// </summary>
	public interface ISerializationContext
	{
		/// <summary>
		/// Begins serializing tag data.
		/// </summary>
		void BeginSerialize();

		/// <summary>
		/// Finishes serializing tag data.
		/// </summary>
		/// <param name="data">The data that was serialized.</param>
		/// <param name="mainStructOffset">The offset of the main structure within the data.</param>
		void EndSerialize(byte[] data, uint mainStructOffset);

		/// <summary>
		/// Begins deserializing tag data.
		/// </summary>
		/// <returns>The reader to read from.</returns>
		BinaryReader BeginDeserialize();

		/// <summary>
		/// Finishes deserializing tag data.
		/// </summary>
		/// <param name="obj">The resulting object.</param>
		void EndDeserialize(object obj);

		/// <summary>
		/// Converts an address to an offset.
		/// </summary>
		/// <param name="currentOffset">The offset that the address is located at.</param>
		/// <param name="address">The address to convert.</param>
		/// <returns>The offset corresponding to the address.</returns>
		uint AddressToOffset(uint currentOffset, uint address);

		/// <summary>
		/// Looks up a tag by its index.
		/// </summary>
		/// <param name="index">The index of the tag to get.</param>
		/// <returns>The tag if it exists, or <c>null</c> otherwise.</returns>
		HaloTag GetTagByIndex(int index);

		/// <summary>
		/// Creates a data block.
		/// </summary>
		/// <returns>The created block.</returns>
		IDataBlock CreateBlock();
	}
}
