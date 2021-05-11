using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public enum FitnessLevel
    {
        [Description("Početna")]
        Beginner,

        [Description("Srednja")]
        Intermediate,

        [Description("Napredna")]
        Advanced
    }
}