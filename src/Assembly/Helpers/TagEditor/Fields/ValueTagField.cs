﻿using Assembly.Helpers.TagEditor.Buffering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assembly.Helpers.TagEditor.Fields
{
	/// <summary>
	/// Base class for a tag field with a value associated with it.
	/// </summary>
	public abstract class ValueTagField : TagField
	{
		private uint _address;
		private string _name;
		private uint _offset;
		private TagBufferSource _source;

		public ValueTagField(string name, uint offset, uint address, uint pluginLine, TagBufferSource source)
		{
			_name = name;
			_offset = offset;
			_address = address;
			PluginLine = pluginLine;
			_source = source;
		}

		/// <summary>
		/// Gets or sets the field's name.
		/// </summary>
		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				NotifyPropertyChanged("Name");
			}
		}

		/// <summary>
		/// Gets or sets the offset of the field's value from the start of its tag buffer.
		/// </summary>
		public uint Offset
		{
			get { return _offset; }
			set
			{
				_offset = value;
				NotifyPropertyChanged("Offset");
			}
		}

		/// <summary>
		/// Gets or sets the estimated memory address of the field's value.
		/// Do not rely upon the accuracy of this value, especially when saving or poking.
		/// </summary>
		public uint FieldAddress
		{
			get { return _address; }
			set
			{
				_address = value;
				NotifyPropertyChanged("FieldAddress");
			}
		}

		/// <summary>
		/// Gets or sets the tag buffer source which the value is bound to.
		/// </summary>
		public TagBufferSource Source
		{
			get { return _source; }
			set
			{
				_source = value;
				NotifyPropertyChanged("Source");
			}
		}

		/// <summary>
		/// Accepts the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor.</param>
		public abstract override void Accept(ITagFieldVisitor visitor);
	}
}
