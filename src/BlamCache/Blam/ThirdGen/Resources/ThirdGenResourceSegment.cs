﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtryzeDLL.Flexibility;

namespace ExtryzeDLL.Blam.ThirdGen.Resources
{
    public class ThirdGenResourceSegment
    {
        public ThirdGenResourceSegment(StructureValueCollection values, ThirdGenResourcePage[] pages)
        {
            Load(values, pages);
        }

        public ThirdGenResourcePage PrimaryPage { get; set; }
        public int PrimaryOffset { get; set; }

        public ThirdGenResourcePage SecondaryPage { get; set; }
        public int SecondaryOffset { get; set; }

        private void Load(StructureValueCollection values, ThirdGenResourcePage[] pages)
        {
            int primaryIndex = (int)values.GetNumber("primary page index");
            if (primaryIndex >= 0)
                PrimaryPage = pages[primaryIndex];

            int secondaryIndex = (int)values.GetNumber("secondary page index");
            if (secondaryIndex >= 0)
                SecondaryPage = pages[secondaryIndex];

            PrimaryOffset = (int)values.GetNumber("primary offset");
            SecondaryOffset = (int)values.GetNumber("secondary offset");
        }
    }
}