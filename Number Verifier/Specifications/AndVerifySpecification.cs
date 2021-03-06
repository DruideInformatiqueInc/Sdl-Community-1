﻿using Sdl.Community.NumberVerifier.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdl.Community.NumberVerifier.Specifications
{
    public class AndVerifySpecification : IVerifySpecification
    {
        public IVerifySpecification[] Specifications;
        public bool IsSatisfiedBy(INumberResults numberResults)
        {
            return this.Specifications.All(s => s.IsSatisfiedBy(numberResults));
        }
    }
}
