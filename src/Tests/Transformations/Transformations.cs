﻿using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Tests.Transformations
{
    public class Transformations
    {
        [StepArgumentTransformation(@"{(.*)}")]
        public List<string> ToList(string path)
        {
            return path.Split(',').ToList();
        }

    }
}
