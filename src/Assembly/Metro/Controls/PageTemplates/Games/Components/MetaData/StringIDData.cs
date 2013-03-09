﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blamite.Blam;

namespace Assembly.Metro.Controls.PageTemplates.Games.Components.MetaData
{
    public class StringIDData : ValueField
    {
        private StringID _value;
        private StringIDSource _source;

        public StringIDData(string name, uint offset, uint address, StringID sid, StringIDSource source, uint pluginLine)
            : base(name, offset, address, pluginLine)
        {
            _value = sid;
            _source = source;
        }

        public StringID Value
        {
            get { return _value; }
            set { _value = value; NotifyPropertyChanged("Value"); NotifyPropertyChanged("StringValue"); }
        }

        public string StringValue
        {
            get { return _source.GetString(Value); }
            set { Value = _source.FindStringID(value); NotifyPropertyChanged("StringValue"); }
        }

        public StringIDSource StringSource
        {
            get { return _source; }
            set { _source = value; NotifyPropertyChanged("StringSource"); }
        }

        public override void Accept(IMetaFieldVisitor visitor)
        {
            visitor.VisitStringID(this);
        }

        public override MetaField CloneValue()
        {
            return new StringIDData(Name, Offset, FieldAddress, _value, _source, base.PluginLine);
        }
    }
}
